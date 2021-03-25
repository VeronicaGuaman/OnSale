using OnSale.Common.Responses;

namespace OnSale.Web.Helpers
{
    public class IMailHelper
    {
        Response SendMail(string to, string subject, string body);
    }
}
