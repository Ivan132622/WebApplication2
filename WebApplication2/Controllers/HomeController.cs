using System.Web.Mvc;



namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult conditions()
        {
            return View();
        }

        public ActionResult use()
        {
            return View();
        }

        public ActionResult forum()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

       

       
    }
}