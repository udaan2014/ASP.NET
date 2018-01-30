using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginRegistration
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["TempConnectionString1"].ConnectionString))
                {

                    connectionString.Open();
                    string id, secret;
                    id = UserIDText.Text;
                    secret = SecretMessageText.Text;
                    if (id == "" || secret == "")
                    {
                        message.Attributes.Add("class", "alert-warning");
                        message.Text = "Please fill all the details";
                        //Response.Write("<script language=javascript>alert('Please fill all the details')</script>");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connectionString;
                        cmd.CommandText = "USP_AuthenticateUserDetails";
                        cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = id;
                        cmd.Parameters.Add("@SecretMessage", SqlDbType.VarChar).Value = secret;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataReader rd = cmd.ExecuteReader();

                        if (rd.HasRows)
                        {
                            Session["UserIDforPassword"] = id;
                            Response.Redirect("ChangePassword.aspx");
                        }
                        else
                            throw (new Exception());
                    }
                }
            }

            catch (Exception)
            {
                message.Attributes.Add("class", "alert-danger");
                message.Text = "User Authentication Failed";
                //Response.Write("<script language=javascript>alert('Error Occurred')</script>");
                UserIDText.Text = "";
                SecretMessageText.Text = "";
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}