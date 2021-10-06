using System.Web;
using System.Web.Mvc;

namespace Bdl_Grupo2_ProyectoFinal_A
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
