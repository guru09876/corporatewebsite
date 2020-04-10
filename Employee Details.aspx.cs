using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
    public partial class Employee_Details : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void But1_Click(object sender, EventArgs e)
        {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into employee values('" + Text1.Text + "','" + TextBox2.Text + "')";
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("Employee Details.aspx");
        }
    }