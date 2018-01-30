using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace LoginRegistration
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Exit(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserID"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            string id = Session["UserID"].ToString();
            try
            {
                using (SqlConnection connectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["TempConnectionString1"].ConnectionString))
                {
                    connectionString.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connectionString;
                    cmd.CommandText = "USP_SelectUserName";
                    cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = id;
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.HasRows)
                    {
                        rd.Read();
                        string name = rd["UserName"].ToString();
                        divCenter.InnerHtml = "<p class='navbar-brand'>" + name + "</p>";
                    }
                    
                }
            }
            catch(Exception)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("UploadPic.aspx");
        }
    }
}