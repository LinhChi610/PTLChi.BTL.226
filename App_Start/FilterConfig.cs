using System.Web;
using System.Web.Mvc;

namespace PTLChi.BTL._226
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
