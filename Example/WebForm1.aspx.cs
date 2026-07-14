using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = "You selected: " + Calendar1.SelectedDate.ToString("dd-MM-yyyy");
            Label2.Text = "Day of week: " + Calendar1.SelectedDate.DayOfWeek;
        }

        protected void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Female_CheckedChanged(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Male.Checked) 
            {
                Label3.Text = "You selected male";
            }
            else if (Female.Checked)
            {
                Label3.Text = "You selected female";
            }
            else
            {
                Label3.Text = "Select Gender";
            }
}

        protected void Button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (C.Checked)
            {
                total = total + 1000;
            }
            if (Csharp.Checked)
            {
                total = total + 2000;
            }
            if (Java.Checked)
            {
                total = total + 3000;
            }
            Label4.Text = "Total Amount: " + total;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label5.Text = "City: " + ListBox1.SelectedItem.ToString();
        }
    }
}