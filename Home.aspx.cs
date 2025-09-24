using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Configartion_Practice
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Do nothing on first load
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["ShopDB"].ToString();
            SqlConnection con = new SqlConnection(conStr);
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 5 Cid, Name, Email FROM Customers", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            int passMarks = Convert.ToInt32(ConfigurationManager.AppSettings["passmarks"]);
            int marks = Convert.ToInt32(txtMarks.Text.Trim());

            if (marks >= passMarks)
            {
                lblResult.Text = "Result: Pass 😊";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResult.Text = "Result: Fail ☹️";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}