using System.Web;
using System.Web.Mvc;

namespace _15.Web_Game_Fruju
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
