using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_management_System
{
    public partial class Show_Student_Info : System.Web.UI.Page
    {
        Dataoperation obj = new Dataoperation();
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
  FROM [dbo].[Student]";
            GridView1.DataSource = obj.Getdata(query);
            GridView1.DataBind();
        }
    }
}