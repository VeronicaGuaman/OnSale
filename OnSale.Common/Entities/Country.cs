﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50,ErrorMessage = "The filels {0} must contains less than {1} characteres.")]
        [Required]
        public string Nombre { get; set; }
    }
}
