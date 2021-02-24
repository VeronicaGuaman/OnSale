﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace OnSale.Web.Migrations
{
    public partial class AddDepartmentsAndCitiesandCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Departments_DepartmentId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Name",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Cities_Name",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Countries",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_Nombre",
                table: "Countries",
                newName: "IX_Countries_Name");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Departments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CountryId",
                table: "Departments",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Name_CountryId",
                table: "Departments",
                columns: new[] { "Name", "CountryId" },
                unique: true,
                filter: "[CountryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name_DepartmentId",
                table: "Cities",
                columns: new[] { "Name", "DepartmentId" },
                unique: true,
                filter: "[DepartmentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Departments_DepartmentId",
                table: "Cities",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Countries_CountryId",
                table: "Departments",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Departments_DepartmentId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Countries_CountryId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_CountryId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Name_CountryId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Cities_Name_DepartmentId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Countries",
                newName: "Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_Name",
                table: "Countries",
                newName: "IX_Countries_Nombre");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Name",
                table: "Departments",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name",
                table: "Cities",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Departments_DepartmentId",
                table: "Cities",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
