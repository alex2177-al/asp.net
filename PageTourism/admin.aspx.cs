using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static PageTourism.HomePageControl;

namespace PageTourism
{
    public partial class admin : System.Web.UI.Page
    {
        public navbar navbar = new navbar();
        public titre titre = new titre();
        public exploreur exploreur = new exploreur();
        public basdepage basdepage = new basdepage();
        public image image = new image();
        public gallerie gallerieimage = new gallerie();

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
                    case "8":
                        navbar.ajout = reader["content"].ToString();
                        break;
                    case "9":
                        navbar.modsup = reader["content"].ToString();
                        break;
                    case "10":
                        navbar.selection = reader["content"].ToString();
                        break;
                    case "11":
                        navbar.consulter = reader["content"].ToString();
                        break;

                }
            }
            con.Close();


            
           
        }




    }
}


