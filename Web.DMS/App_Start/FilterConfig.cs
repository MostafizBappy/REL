using System.Web;
using System.Web.Mvc;

namespace Web.DMS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new UserAuthorization());
        }
    }
}
