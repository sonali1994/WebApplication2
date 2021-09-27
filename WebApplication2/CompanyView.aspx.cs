using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            string connectionString;
            SqlConnection con;
            connectionString = @"Data Source=LAPTOP-B3LMG6VE;Initial Catalog=company;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT Id, name FROM Company_Master";
            cmd.Connection = con;
            
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }
}