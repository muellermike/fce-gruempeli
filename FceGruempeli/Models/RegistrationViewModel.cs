using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FceGruempeli.Models
{
    public class RegistrationViewModel
    {
        public string Company { get; set; }

        [Required(AllowEmptyStrings=false, ErrorMessage="Name ist ein Pflichtfeld")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Vorname ist ein Pflichtfeld")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Strasse ist ein Pflichtfeld")]
        public string Street { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ort ist ein Pflichtfeld")]
        public string City { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Telefon ist ein Pflichtfeld")]
        public string Phone { get; set; }

        public string MobilePhone { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ist ein Pflichtfeld")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Mannschaftsname ist ein Pflichtfeld")]
        public string TeamName { get; set; }

        public string Category { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Captain ist ein Pflichtfeld")]
        public string Captain { get; set; }

        public int Year { get; set; }

        public string Remarks { get; set; }
    }
}