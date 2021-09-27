using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace WebApplication2
{
    public partial class CompanyMaster : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-B3LMG6VE;Initial Catalog=company;Integrated Security=True");

        public object CompanyId { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            /*  string connectionString;
              SqlConnection con;
              connectionString = @"Data Source=LAPTOP-B3LMG6VE;Initial Catalog=company;Integrated Security=True";
              con = new SqlConnection(connectionString);
              con.Open();
            */





        }

        protected void Btnsave_Click(object sender, EventArgs e)
         {
             SqlDataAdapter adapter = new SqlDataAdapter();
             string connectionString;
             SqlConnection con;
             connectionString = @"Data Source=LAPTOP-B3LMG6VE;Initial Catalog=company;Integrated Security=True";
             con = new SqlConnection(connectionString);
             con.Open();
             SqlCommand cmd =new SqlCommand("INSERT INTO Company_Master (name)VALUES(@name)", con);
            
             cmd.Parameters.AddWithValue("@name", TextBox1.Text.Trim());
             cmd.ExecuteNonQuery();
             con.Close();

         }

        protected void Upload(object sender, EventArgs e)
        {

            string connectionString;
            SqlConnection con;
            connectionString = @"Data Source=LAPTOP-B3LMG6VE;Initial Catalog=company;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
            foreach (HttpPostedFile postedFile in fileuplaod1.PostedFiles)
            {
                string FileName = Path.GetFileName(postedFile.FileName);
                string contentType = postedFile.ContentType;
                using (Stream fs = postedFile.InputStream)
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        byte[] bytes = br.ReadBytes((Int32)fs.Length);
                        string constr = ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
                        using (SqlConnection con1 = new SqlConnection(constr))
                        {
                            string query = "insert into FileMaster values(@FileName,@CompanyId)";
                            using (SqlCommand cmd = new SqlCommand(query))
                            {
                                cmd.Connection = con;
                                cmd.Parameters.AddWithValue("@FileName", FileName);
                                cmd.Parameters.AddWithValue("@CompanyId", CompanyId);
                                
                                cmd.ExecuteNonQuery();
                                con1.Close();
                            }
                        }
                    }
                }
            }
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }
    }