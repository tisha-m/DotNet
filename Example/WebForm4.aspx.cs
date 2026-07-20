using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            AdRotator1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                String path = Server.MapPath("~/images/");
                String fileName = FileUpload1.FileName;
                FileUpload1.SaveAs(path + FileUpload1.FileName);
                Label1.Text = "Upload status: File uploaded!";
            }
            else
            {
                Label1.Text = "No file selected.";
            }
        }
    }
}