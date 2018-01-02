using System.Web.Mvc;

namespace AttributeRouting.Controllers
{
    [RouteArea("Admin")]                      //UserRoll for Admin
    [RoutePrefix("Person")]
    [Route("{action}")]                     //Use for Login mathods otherwise error
    public class MenuController : Controller
    {
        // eg: /admin/menu/login
        public ActionResult Login()
        {
            return View();
        }

        // eg: /admin/menu/options
        [Route("Options")]
        public ActionResult Options()
        {
            return View();
        }
    }
}