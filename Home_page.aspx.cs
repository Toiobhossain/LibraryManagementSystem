using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_management_System
{
    public partial class Home_page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Book_page.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentFrom.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Show_Book_Info.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Show_Student_Info.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Borrow_Book_info.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Update_info.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delete_info.aspx");
        }
        

        protected void Button8_Click(object sender, EventArgs e)
        {
            showimage();
        }

        private void showimage()
        {
            string url = Image1.ImageUrl;
            Image1.ImageUrl = Image2.ImageUrl;
            Image2.ImageUrl = Image3.ImageUrl;
            Image3.ImageUrl = url;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            string url = Image3.ImageUrl;
            Image3.ImageUrl = Image2.ImageUrl;
            Image2.ImageUrl = Image1.ImageUrl;
            Image1.ImageUrl = url;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            showimage();
        }
    }
}