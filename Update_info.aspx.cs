using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_management_System
{
    
    public partial class Update_info : System.Web.UI.Page
    {
        Dataoperation obj = new Dataoperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
            showdata();
            Show1Data();
            Show2data();
            }
           
        }
        public void showdata()
        {
            string query = @"SELECT [Book_ID]
      ,[Book_Name]
      ,[Book_authore_Name]
      ,[Book_publication_Name]
      ,[Book_purchase_Date]
      ,[Book_Price]
      ,[Book_Quantity]
  FROM [dbo].[Books]";
            GridView1.DataSource = obj.Getdata(query);
            GridView1.DataBind();

        }
        public void Show1Data()
        {
            string query = @"SELECT [Student_ID]
      ,[Student_Name]
      ,[Department]
      ,[Phone_Number]
      ,[Address]
      ,[Gender]
      ,[Email]
      ,[Image]
  FROM [dbo].[Student]";
            GridView2.DataSource = obj.Getdata(query);
            GridView2.DataBind();
        }
        public void Show2data()
        {
            string query = @"SELECT [Student_ID]
      ,[Student_Name]
      ,[Department]
      ,[Phone_Number]
      ,[Address]
      ,[Gender]
      ,[Email]
      ,[Image]
      ,[Book_Name]
      ,[Book_authore_Name]
      ,[Book_publication_Name]
      ,[Book_purchase_Date]
  FROM [dbo].[Student] inner join [dbo].[Books]
  on Student.Book_ID=Books.Book_ID";
            GridView3.DataSource = obj.Getdata(query);
            GridView3.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            showdata();
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
           
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lblID = (Label)GridView1.Rows[e.RowIndex].FindControl("Label7");
            TextBox textID = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox7");
            TextBox textName = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox6");
            TextBox textauName = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox5");
            TextBox textpuName = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox4");
            TextBox textpudate = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3");
            TextBox textprice = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2");
            TextBox textquntity = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
            string query = @"UPDATE [dbo].[Books] SET [Book_Name] ='" +textName.Text + "',[Book_authore_Name] ='" + textauName.Text + "',[Book_publication_Name] ='" + textpuName.Text + "'  ,[Book_purchase_Date] ='" + textpudate.Text + "' ,[Book_Price] = '" + textprice.Text + "',[Book_Quantity] ='" + textquntity.Text + "' WHERE Book_ID=" + textID.Text;
            if (obj.insertdata(query) == 1)
            {
                GridView1.EditIndex = -1;
                showdata();

            }
           
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lblID = (Label)GridView2.Rows[e.RowIndex].FindControl("Label7");
            TextBox textID = (TextBox)GridView2.Rows[e.RowIndex].FindControl("TextBox8");
            TextBox textName = (TextBox)GridView2.Rows[e.RowIndex].FindControl("TextBox7");
            TextBox textDepartment = (TextBox)GridView2.Rows[e.RowIndex].FindControl("TextBox6");
            TextBox textPhone = (TextBox)GridView2.Rows[e.RowIndex].FindControl("TextBox5");
            TextBox textAddress = (TextBox)GridView2.Rows[e.RowIndex].FindControl("TextBox4");
            TextBox textGender = (TextBox)GridView2.Rows[e.RowIndex].FindControl("TextBox3");
            TextBox textEmail = (TextBox)GridView2.Rows[e.RowIndex].FindControl("TextBox2");
            TextBox textimage = (TextBox)GridView2.Rows[e.RowIndex].FindControl("TextBox1");
            string query = @"UPDATE [dbo].[Student] SET [Student_ID] ='" + textID.Text + "' ,[Student_Name] ='" + textName.Text + "' ,[Department] ='" + textDepartment.Text + "' ,[Phone_Number] ='" + textPhone.Text + "' ,[Address] ='" + textAddress.Text + "' ,[Gender] ='" + textGender.Text + "' ,[Email] ='" + textEmail.Text + "' ,[Image] ='" + textimage.Text + "'  WHERE Student_ID="+textID.Text;
            if(obj.insertdata(query)==1)
            {
                GridView2.EditIndex = -1;
                Show1Data();
            }


        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            Show1Data();
        }

        protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lblID = (Label)GridView3.Rows[e.RowIndex].FindControl("Label11");
            TextBox textID = (TextBox)GridView3.Rows[e.RowIndex].FindControl("TextBox12");
            TextBox textName = (TextBox)GridView3.Rows[e.RowIndex].FindControl("TextBox11");
            TextBox textDepartment = (TextBox)GridView3.Rows[e.RowIndex].FindControl("TextBox10");
            TextBox textPhone = (TextBox)GridView3.Rows[e.RowIndex].FindControl("TextBox9");
            TextBox textAddress = (TextBox)GridView3.Rows[e.RowIndex].FindControl("TextBox8");
            TextBox textGender = (TextBox)GridView3.Rows[e.RowIndex].FindControl("TextBox7");
            TextBox textEmail = (TextBox)GridView3.Rows[e.RowIndex].FindControl("TextBox6");
            TextBox textimage = (TextBox)GridView3.Rows[e.RowIndex].FindControl("TextBox1");
            string query = @"UPDATE [dbo].[Student] SET [Student_ID] ='" + textID.Text + "' ,[Student_Name] ='" + textName.Text + "' ,[Department] ='" + textDepartment.Text + "' ,[Phone_Number] ='" + textPhone.Text + "' ,[Address] ='" + textAddress.Text + "' ,[Gender] ='" + textGender.Text + "' ,[Email] ='" + textEmail.Text + "' ,[Image] ='" + textimage.Text + "'  WHERE Student_ID=" + textID.Text;
            if (obj.insertdata(query) == 1)
            {
                GridView3.EditIndex = -1;
                Show2data();
            }
        }

        protected void GridView3_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView3.EditIndex = e.NewEditIndex;
            Show2data();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}