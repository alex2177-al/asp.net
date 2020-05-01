using System;
using System.Net;
using System.Net.Mail;
using static PageTourism.HomePageControl;

namespace PageTourism
{
    public partial class consulter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool sendMail(Email email)
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

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (sendMail(new Email { To = TxtTo.Text, Subject = txtSubject.Text, Message = txtMessage.Text }))
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
    }
}