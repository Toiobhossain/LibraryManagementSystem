using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_management_System
{
    public partial class Borrow_Book_info : System.Web.UI.Page
    {
        Dataoperation obj=new Dataoperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        public void ShowData()
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
  FROM [dbo].[Student] inner join  [dbo].[Books]
 on Student.Book_ID=Books.Book_ID";
            GridView1.DataSource = obj.Getdata(query);
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}