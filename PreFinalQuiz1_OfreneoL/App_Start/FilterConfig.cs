using System.Web;
using System.Web.Mvc;

namespace PreFinalQuiz1_OfreneoL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
