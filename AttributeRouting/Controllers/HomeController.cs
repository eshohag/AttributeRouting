using System.Web.Mvc;

namespace AttributeRouting.Controllers
{
    [RoutePrefix("Products")]
    // [Route("{action=Index}")]             //Same as Default rote for specific action like: http://localhost:3669/Products/Index
    public class HomeController : Controller
    {
        [Route("~/")]                       //Default Route for entier applications Like: http://localhost:3669/
        [Route("")]                         //Default rote for specific action like: http://localhost:3669/Products
        [Route("Index")]                    //Default rote for specific action like: http://localhost:3669/Products/Index
        public ActionResult Index()
        {
            return View();
        }



        [Route("Details/{id:int}")]              //Calling URL like:  http://localhost:3669/Products/Details/1
        [Route("Details/{id:int}/{name}")]       //Calling URL like:  http://localhost:3669/Products/Details/1/shohag
        public ActionResult Details(int id, string name)
        {
            ViewBag.Message = "Your details id=" + id + " and Name=" + name;

            return View();
        }












        [Route("~/About")]     //Calling URL Like: http://localhost:3669/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("~/Contact")]      //Calling URL Like: http://localhost:3669/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }





        [Route("Orders/{id:int}", Name = "ProductOrder", Order = 2)]
        public ActionResult Orders()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }









    }
}