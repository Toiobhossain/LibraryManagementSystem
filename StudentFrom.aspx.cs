using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_management_System
{
    public partial class StudentFrom : System.Web.UI.Page
    {
        Dataoperation obj = new Dataoperation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string str = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "//Uploads//" + str);
                string path = "~//Uploads//" + str.ToString();
                string query = @"INSERT INTO [dbo].[Student]
           ([Student_ID]
           ,[Student_Name]
           ,[Department]
           ,[Phone_Number]
           ,[Address]
           ,[Gender]
           ,[Email]
           ,[Image]
           ,[Book_ID])
     VALUES('" + TextID.Text + "','" + TextName.Text + "','" + TextDepartment.Text + "','" + TextNumber.Text + "','" + TextAddress.Text + "','" + DropDownListGender.Text + "','" + TextEmail.Text + "','" + path + "','" + TextBookId.Text+ "')";
                obj.insertdata(query);
                lblmsg.Text = "Student Information Successfully Store!";

            }

     
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextID.Text = " ";
            TextName.Text = " ";
            TextDepartment.Text = " ";
            TextNumber.Text = " ";
            TextAddress.Text = " ";
            TextEmail.Text = "  ";
            TextBookId.Text = " ";
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_page.aspx");
        }
    }
}