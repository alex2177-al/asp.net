using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using static PageTourism.HomePageControl;
using System.Data;
using System.Data.SqlClient;

namespace PageTourism
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public navbar navbar = new navbar();
        public titre titre = new titre();
        public exploreur exploreur = new exploreur();
        public basdepage basdepage = new basdepage();
        public image image = new image();
        public gallerie gallerieimage = new gallerie();
        public Voyage Voya = new Voyage();

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Alex\Desktop\pppp\PageTourism\App_Data\TourismDataBase.mdf; Integrated Security = True");
            
            SqlCommand nav = new SqlCommand("Select * from NAV", con);
            con.Open();
            SqlDataReader reader = nav.ExecuteReader();
                while (reader.Read())
                {
                    switch (reader["Id"].ToString())
                    {
                        case "1":
                            navbar.Home = reader["content"].ToString();
                            break;
                        case "2":
                            navbar.About = reader["content"].ToString();
                            break;
                        case "3":
                            navbar.Pages = reader["content"].ToString();
                            break;
                        case "4":
                            navbar.Gallery = reader["content"].ToString();
                            break;
                        case "5":
                            navbar.Blog = reader["content"].ToString();
                            break;
                        case "6":
                            navbar.Contact = reader["content"].ToString();
                            break;
                        case "7":
                            navbar.loginadmin = reader["content"].ToString();
                            break;
                }
                }
                con.Close();
            
            
            SqlCommand title = new SqlCommand("Select * from Title", con);
            con.Open();
            SqlDataReader titlereader = title.ExecuteReader();
            while (titlereader.Read())
            {
                switch (titlereader["Id"].ToString())
                {
                    case "1":
                        titre.Title = titlereader["title"].ToString();
                        break;
                }
            }
            con.Close();
           

            SqlCommand Explo = new SqlCommand("Select * from Explorer", con);
            con.Open();
            SqlDataReader exploreader = Explo.ExecuteReader();
            while (exploreader.Read())  
            {
                switch (exploreader["Id"].ToString())
                {
                    case "1":
                        exploreur.exploreLineOne = exploreader["ExploreText"].ToString();
                    break;

                    case "2":
                        exploreur.exploreLineTwo = exploreader["ExploreText"].ToString();
                    break;

                }
            }
            con.Close();
            

            SqlCommand bottom = new SqlCommand("Select* from bottom",con);
            con.Open();
            SqlDataReader bottomreader = bottom.ExecuteReader();
            while (bottomreader.Read())
            {
                switch (bottomreader["Id"].ToString())
                {
                    case "1":
                        basdepage.leftBox = bottomreader["bottomText"].ToString();
                        break;
                    case "2":
                        basdepage.middleBox = bottomreader["bottomText"].ToString();
                        break;
                    case "3":
                        basdepage.rightBox = bottomreader["bottomText"].ToString();
                        break;
                    case "4":
                        basdepage.leftboxTEXT = bottomreader["bottomText"].ToString();
                        break;
                    case "5":
                        basdepage.middleboxTEXT = bottomreader["bottomText"].ToString();
                        break;
                    case "6":
                        basdepage.rightTEXT = bottomreader["bottomText"].ToString();
                        break;
                }

            }
            con.Close();

            SqlCommand Voy = new SqlCommand("Select * from Voyage", con);
            con.Open();
            SqlDataReader VoyReader = Voy.ExecuteReader();
            while (VoyReader.Read())
            {
                switch (VoyReader["Id"].ToString())
                {
                    case "1":
                        Voya.titre1 = VoyReader["titre"].ToString();
                        Voya.desc1 = VoyReader["description"].ToString();
                        Voya.prix1 = VoyReader["prix"].ToString();
                        Voya.photo1 = VoyReader["photo"].ToString();
                        break;
                    case "2":
                        Voya.titre2 = VoyReader["titre"].ToString();
                        Voya.desc2 = VoyReader["description"].ToString();
                        Voya.prix2 = VoyReader["prix"].ToString();
                        Voya.photo2 = VoyReader["photo"].ToString();
                        break;
                    case "3":
                        Voya.titre3 = VoyReader["titre"].ToString();
                        Voya.desc3 = VoyReader["description"].ToString();
                        Voya.prix3 = VoyReader["prix"].ToString();
                        Voya.photo3 = VoyReader["photo"].ToString();
                        break;
                }
            }
            con.Close();



            SqlCommand gallery = new SqlCommand("select * from gallery",con);
            con.Open();
            SqlDataReader galleryReader = gallery.ExecuteReader();
            while (galleryReader.Read())
            {
                switch (galleryReader["Id"].ToString())
                {
                    case "1":
                        gallerieimage.images = galleryReader["Images"].ToString();
                        break;
                    case "2":
                        gallerieimage.images2 = galleryReader["Images"].ToString();
                        break;
                    case "3":
                        gallerieimage.images3 = galleryReader["Images"].ToString();
                        break;
                    case "4":
                        gallerieimage.images4 = galleryReader["Images"].ToString();
                        break;
                    case "5":
                        gallerieimage.images5 = galleryReader["Images"].ToString();
                        break;
                    case "6":
                        gallerieimage.images6 = galleryReader["Images"].ToString();
                        break;
                }
            }
            con.Close();

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

        SqlConnection con1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Alex\Desktop\pppp\PageTourism\App_Data\TourismDataBase.mdf; Integrated Security = True");
        protected void btnSend_Click(object sender, EventArgs e)
        {


            if (sendMail(new Email { To = TxtTo.Text, Subject = txtSubject.Text, Message = "On voit envoit un message sous peu" }))
            {
                string str = "Sent";
                Response.Write("<script language=javascript>alert('" + str + "');</script>");
                string sql = "INSERT INTO Email (email,subject,text) VALUES (@Val8,@Val9,@Val10)";
                try
                {
                    con1.Open();
                    SqlCommand cmd = new SqlCommand(sql, con1);
                    cmd.Parameters.AddWithValue("@Val8", TxtTo.Text);
                    cmd.Parameters.AddWithValue("@Val9", txtSubject.Text);
                    cmd.Parameters.AddWithValue("@Val10", txtMessage.Text);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    string msg = "Insert Error:";
                    msg += ex.Message;
                    throw new Exception(msg);


                }
                finally
                {
                    Response.Redirect("Contact.aspx");
                    con1.Close();
                }

            }
            else
            {
                string str2 = "Not Sent";
                Response.Write("<script language=javascript>alert('" + str2 + "');</script>");
            }



        }

    }

  

    
}
    

