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
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserIDforPassword"] == null)
                Response.Redirect("ForgotPassword.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Password1.Text == "" || Password2.Text == "")
            {
                message.Attributes.Add("class", "alert-danger");
                message.Text = "Please Fill all the Fields";
            }
            else if (Password2.Text != Password1.Text)
            {
                message.Attributes.Add("class", "alert-danger");
                message.Text = "Passwords are not matching";
            }
            else
            {
                try
                {
                    string id = Session["UserIDforPassword"].ToString();
                    string pass = Password1.Text;
                    using (SqlConnection connectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["TempConnectionString1"].ConnectionString))
                    {

                        connectionString.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connectionString;
                        cmd.CommandText = "USP_ChangePassword";

                        cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = id;
                        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = pass;
                        cmd.CommandType = CommandType.StoredProcedure;

                        int rd = cmd.ExecuteNonQuery();

                        if (rd > 0)
                        {
                            message.Attributes.Add("class", "alert-success");
                            message.Text = "Change password Successful";
                            Password1.Text = "";
                            Password2.Text = "";
                            Session["UserIDforPassword"] = null;
                        }
                        else
                            throw (new Exception());
                    }
                }
                catch (Exception ex)
                {
                    message.Attributes.Add("class", "alert-danger");
                    message.Text = "Change Password Failed";
                }
            }

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Session["UserIDforPassword"] = null;
            Session.Clear();
            Response.Redirect("Login.aspx");
        }

    }
}