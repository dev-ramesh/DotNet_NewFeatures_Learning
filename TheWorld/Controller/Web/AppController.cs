using Microsoft.AspNetCore.Mvc;
using TheWorld.Services;
using TheWorld.ViewModels;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        public IMailService service;

        public AppController(IMailService mailService)
        {
            this.service = mailService;

        }


        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {

            return View();
        }
        public ActionResult Contact()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel contactViewModel)
        {
            service.SendMail("helpCustomer@info.com", contactViewModel.Email, "Customer Care", contactViewModel.Message);
            return View();
        }

    }
}
