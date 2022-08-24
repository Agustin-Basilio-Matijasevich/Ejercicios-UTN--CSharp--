using System.Web;
using System.Web.Mvc;

namespace Prueba_ASPNET_Clase2LAB4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
