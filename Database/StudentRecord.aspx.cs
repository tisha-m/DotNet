using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=demo;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "insert into Student_Record values(@n, @b, @s, @c, @g)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@n", name.Text);
            cmd.Parameters.AddWithValue("@b", branch.Text);
            cmd.Parameters.AddWithValue("@s", sem.Text);
            cmd.Parameters.AddWithValue("@c", city.Text);
            cmd.Parameters.AddWithValue("@g", gender.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script> alert('Registered') </script>");

        }
    }
}