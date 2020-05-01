using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using static PageTourism.HomePageControl;
using System.Data;
using System.Data.SqlClient;


namespace PageTourism
{
    public partial class inscription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInscription(object sender, EventArgs e)
        {
            if (sendConfirmation(new Email { To = TxtTo2.Text, Subject = "Voyage", Message = "We will get back to you shortly with additional information!" }))
            {
                string str = "Sent";
                Response.Write("<script language=javascript>alert('" + str + "');</script>");
            }
            else
            {
                string str2 = "Not Sent";
                Response.Write("<script language=javascript>alert('" + str2 + "');</script>");
            }

        }

        private bool sendConfirmation(Email email)
        {
            bool status = false;
            try
            {
                string MailSender = "alex_hockey21@live.ca";
                string MailPw = "Terrebonne0123";

                SmtpClient smtpClient = new SmtpClient("smtp.office365.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 100000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(MailSender, MailPw);

                MailMessage mailMessage = new MailMessage(MailSender, email.To, email.Subject, email.Message);
                mailMessage.IsBodyHtml = true;
                mailMessage.BodyEncoding = System.Text.UTF8Encoding.UTF8;

                smtpClient.Send(mailMessage);

                status = true;
                return status; ;
            }
            catch (Exception ex)
            {
                return status;
            }
        }
    }
}