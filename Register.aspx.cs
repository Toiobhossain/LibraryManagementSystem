using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_management_System
{
    public partial class Register : System.Web.UI.Page
    {
        Dataoperation obj = new Dataoperation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             string query = @"INSERT INTO [dbo].[Register_user]
           ([First_Name]
           ,[Last_Name]
           ,[Full_Name]
           ,[Password]
           ,[Gender]
           ,[Phone_Number]
           ,[City])
     VALUES('" + TextFname.Text + "','" + TextLname.Text + "','" + TextFullname.Text + "','" + TextPassword.Text + "','" + DropDownListGender.SelectedValue + "','" + TextPhone.Text + "','" + DropDownListCity.SelectedValue + "')";
                obj.insertdata(query);
            
           
            lblmsg.Text = "Registration Successfull !";
            /*TextFname.Text = "";
            TextLname.Text = "";
            TextFullname.Text = "";
            TextPassword.Text = "";
            TextPhone.Text = "";*/

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginFrom.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextFname.Text = "";
            TextLname.Text = "";
            TextFullname.Text = "";
            TextPassword.Text = "";
            TextPhone.Text = "";
        }
    }
}
