using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PageTourism
{
   
    

    public partial class ajout : System.Web.UI.Page
    {
        SqlConnection con1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Alex\Desktop\pppp\PageTourism\App_Data\TourismDataBase.mdf; Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b2_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO voyage (titre,description,prix,photo) VALUES (@Val1,@Val2,@Val3,@Val4)";
            try
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand(sql, con1);
                cmd.Parameters.AddWithValue("@Val1", t3.Text);
                cmd.Parameters.AddWithValue("@Val2", t4.Text);
                cmd.Parameters.AddWithValue("@Val3", t5.Text);
                cmd.Parameters.AddWithValue("@Val4", up1.FileName);
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
                Response.Redirect("admin.aspx");
                con1.Close();
            }
        }
    }
}