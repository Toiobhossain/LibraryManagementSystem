using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace Library_management_System
{
    public partial class LoginFrom : System.Web.UI.Page
    {
        Dataoperation obj = new Dataoperation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = @"select * from Register_user where Full_Name='" + TextName.Text + "'and Password='" + TextPassword.Text + "'";
            if(obj.Getdata(query).Rows.Count==0)
            {
                lblmsg.Text = "User name & password doesn't match!Please try again";
                TextName.Text = "";
               
            }
            else
            {
               
                Response.Redirect("Home_page.aspx");
                
            }
        }
    }
}