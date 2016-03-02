using FceGruempeli.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FceGruempeli.ViewModels
{
    public class RegistrationViewModel
    {
        public RegistrationViewModel()
        {
            Categories = new List<SelectListItem>()
            {
                new SelectListItem() { Selected = true, Text = "Plauschmannschaften", Value = "Plauschmannschaften" },
                new SelectListItem() { Selected = false, Text = "Nichtfussballer", Value = "Nichtfussballer" },
                new SelectListItem() { Selected = false, Text = "Firmen", Value = "Firmen" },
                new SelectListItem() { Selected = false, Text = "Sie &amp; Er", Value = "Sie &amp; Er" },
                new SelectListItem() { Selected = false, Text = "Fussball-Schülerturnier", Value = "Fussball-Schülerturnier" }
            };
        }

        public Person Requester { get; set; }

        public Team Team { get; set; }

        public string Remarks { get; set; }

        public List<SelectListItem> Categories { get; set; }
    }
}
