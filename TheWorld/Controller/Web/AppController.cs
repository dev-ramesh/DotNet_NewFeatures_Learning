using Microsoft.AspNetCore.Mvc;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
        
    }
}
