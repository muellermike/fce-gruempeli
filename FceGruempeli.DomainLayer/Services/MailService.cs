using FceGruempeli.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FceGruempeli.DomainLayer.Services
{
    public class MailService
    {
        public bool SendMail(Person person, Team team, string remarks)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress("miki.mueller@hotmail.com", "FC Eschlikon"));
            msg.From = new MailAddress("miki.mueller@hotmail.com", "FC Eschlikon");
            msg.Subject = "Grümpi16 - Anmeldung";
            var body = new StringBuilder("Eine neu grümpi-Anmeldung erhalten. <br /><br />Zur Person: <br />");
            body.AppendFormat("Vorname: {0}<br />", person.FirstName);
            body.AppendFormat("Nachname: {0}<br />", person.LastName);

            if (!string.IsNullOrEmpty(person.Company))
                body.AppendFormat("Firma: {0}<br >/", person.Company);

            body.AppendFormat("Strasse / Nr: {0}<br />", person.Street);
            body.AppendFormat("PLZ: {0}<br />", person.Plz);
            body.AppendFormat("Ort: {0}<br />", person.City);
            body.AppendFormat("Telefon: {0}<br />", person.Phone);

            if (!string.IsNullOrEmpty(person.MobilePhone))
                body.AppendFormat("Mobil: {0}<br >/", person.MobilePhone);

            body.AppendFormat("Email: {0}<br />", person.Email);

            body.AppendFormat("-------------- T E A M ------------");

            body.AppendFormat("Mannschaftsname: {0}<br />", team.Name);
            body.AppendFormat("Kategorie: {0}<br />", team.Category);
            body.AppendFormat("Captain: {0}<br />", team.Captain);
            body.AppendFormat("Jahrgang: {0}<br />", team.Year);

            if (!string.IsNullOrEmpty(remarks))
            {
                body.AppendFormat("---------- B E M E R K U N G E N -----------");
                body.AppendFormat(remarks);
            }

            msg.Body = body.ToString();
            msg.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("fceschlikon@hotmail.com", "your password");
            client.Port = 587; // You can use Port 25 if 587 is blocked (mine is!)
            client.Host = "smtp.office365.com";
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            try
            {
                client.Send(msg);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
