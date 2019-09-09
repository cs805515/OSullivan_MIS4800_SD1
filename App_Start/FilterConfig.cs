using System.Web;
using System.Web.Mvc;

namespace OSullivan_MIS4800_SD1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
