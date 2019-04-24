using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_management_System
{
    public partial class Book_page : System.Web.UI.Page
    {
        Dataoperation obj = new Dataoperation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextpuDate.Text = Calendar1.SelectedDate.ToString("");
            Calendar1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string query = @"INSERT INTO [dbo].[Books]
           ([Book_Name]
           ,[Book_authore_Name]
           ,[Book_publication_Name]
           ,[Book_purchase_Date]
           ,[Book_Price]
           ,[Book_Quantity])
     VALUES('"+TextName.Text+"','"+TextAuName.Text+"','"+TextpuName.Text+"','"+TextpuDate.Text+"','"+TextPrice.Text+"','"+TextQuantity.Text+"')";
            obj.insertdata(query);
            lblmsg.Text = "Information Successfully store!";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextName.Text = " ";
            TextAuName.Text = " ";
            TextpuName.Text = " ";
            TextpuDate.Text = " ";
            TextPrice.Text = " ";
            TextQuantity.Text = " ";

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_page.aspx");
        }
    }
}