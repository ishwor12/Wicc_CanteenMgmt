using System.Web;
using System.Web.Mvc;

namespace Canteen_Management_Project_WICC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
