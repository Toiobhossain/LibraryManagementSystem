using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_management_System
{
    public partial class Show_Book_Info : System.Web.UI.Page
    {
        Dataoperation obj = new Dataoperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        public void ShowData()
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.Visible = (false);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView1.Visible = (true);
        }
    }
}