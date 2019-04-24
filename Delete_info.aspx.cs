using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_management_System
{
    public partial class Delete_info : System.Web.UI.Page
    {
        Dataoperation obj = new Dataoperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            showdata();
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

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblId = (Label)GridView1.Rows[e.RowIndex].FindControl("Label7");
            string query = @"DELETE FROM [dbo].[Books]
      WHERE Book_ID=" + lblId.Text;
            if(obj.insertdata(query)==1)
            {
                showdata();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
