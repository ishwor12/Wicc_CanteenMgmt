using System.Web;
using System.Web.Mvc;

namespace KnockOut_PQ_master_detail
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
