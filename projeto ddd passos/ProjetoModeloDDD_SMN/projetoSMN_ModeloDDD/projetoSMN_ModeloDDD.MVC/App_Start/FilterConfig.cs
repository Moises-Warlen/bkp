using System.Web;
using System.Web.Mvc;

namespace projetoSMN_ModeloDDD.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
