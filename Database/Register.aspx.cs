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
            //    string connectionString = "C:\\Users\\tisha\\AppData\\Local\\Microsoft\\VisualStudio\\SSDT\\demo.mdf";
            //    SqlConnection con = new SqlConnection(connectionString);

            //    con.Open();
            //    string query = "insert into Register1 values('" + idtxt.Text + "','" + nametxt.Text + "', '" + pwdtxt.Text + "', '" + emailtxt.Text + "', '" + contactnotxt.Text +"');";
            //    SqlCommand cmd = new SqlCommand(query, con);

            //    cmd.ExecuteNonQuery();
            //    Response.Write("Inserted successfully");

            //    con.Close();

            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=demo;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "insert into Register1 values(@i,@n, @p, @e, @c)";
            SqlCommand cmd = new SqlCommand(query, con);     
            
            cmd.Parameters.AddWithValue("@i", idtxt.Text);
            cmd.Parameters.AddWithValue("@n", nametxt.Text);
            cmd.Parameters.AddWithValue("@p", pwdtxt.Text);
            cmd.Parameters.AddWithValue("@e", emailtxt.Text);
            cmd.Parameters.AddWithValue("@c", contactnotxt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script> alert('Registered') </script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}