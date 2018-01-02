using System.Web.Mvc;
using System.Web.Routing;

namespace AttributeRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            //Newly added for custome route create
            routes.MapMvcAttributeRoutes();

            //Newly added for UserRoll like Admin & User etc 
            AreaRegistration.RegisterAllAreas();





            ////Default Routing in Applications
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
