using System.Web;
using System.Web.Mvc;

namespace Mono_TestProject_Birovljevic
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
