using FceGruempeli.Models;
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
        public ActionResult Index()
        {
            RegistrationViewModel viewModel = new RegistrationViewModel();

            return View(viewModel);
        }

        public ActionResult Register(RegistrationViewModel viewModel)
        {
            return View();
        }
    }
}