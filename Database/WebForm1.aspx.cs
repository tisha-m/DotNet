using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string connectionString = "C:\\Users\\tisha\\AppData\\Local\\Microsoft\\VisualStudio\\SSDT\\demo.mdf";
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            String query = "insert into Register values('" + idtxt.Text + "','" + nametxt.Text + "', '" + pwdtxt.Text + "', '" + emailtxt.Text + "', '" + contactnotxt.Text +"');";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
            Response.Write("Inserted successfully");

            con.Close();
        }
    }
}