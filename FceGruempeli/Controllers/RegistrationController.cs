using FceGruempeli.DomainLayer.Services;
using FceGruempeli.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FceGruempeli.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [HttpGet]
        public ActionResult Index()
        {
            RegistrationViewModel viewModel = new RegistrationViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(RegistrationViewModel viewModel)
        {
            MailService service = new MailService();
            bool sent = service.SendMail(viewModel.Requester, viewModel.Team, viewModel.Remarks);
            if (!sent)
            {
                return View("Error");
            }
            return View("Success");
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}