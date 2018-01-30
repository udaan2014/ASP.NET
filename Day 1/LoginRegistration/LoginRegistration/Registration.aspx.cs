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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["TempConnectionString1"].ConnectionString))
                {

                    connectionString.Open();
                    string name, id, password,secret;
                    name = UserNameText.Text;
                    id = UserIDText.Text;
                    password = PasswordText.Text;
                    secret = SecretMessageText.Text;
                    if (name == "" || id == "" || password == ""||secret=="")
                    {
                        message.Attributes.Add("class", "alert-warning");
                        message.Text = "Please fill all the details";
                        //Response.Write("<script language=javascript>alert('Please fill all the details')</script>");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connectionString;
                        cmd.CommandText = "USP_InsertUserDetails";

                        cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = id;
                        cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = name;
                        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                        cmd.Parameters.Add("@SecretMessage", SqlDbType.VarChar).Value = secret;
                        cmd.CommandType = CommandType.StoredProcedure;

                        int rd = 0;
                        rd = cmd.ExecuteNonQuery();
                        if (rd > 0)
                        {
                            message.Attributes.Add("class", "alert-success");
                            message.Text = "Registration Successful";

                            //Response.Write("<script language=javascript>alert('Insertion Successful')</script>");
                            UserIDText.Text = "";
                            UserNameText.Text = "";
                            PasswordText.Text = "";
                            SecretMessageText.Text = "";
                        }
                        else
                            throw (new Exception());
                    }        
                }
            }
            catch (Exception)
            {
                message.Attributes.Add("class", "alert-danger");
                message.Text = "Registration Failed";
                //Response.Write("<script language=javascript>alert('Error Occurred')</script>");
                UserIDText.Text = "";
                UserNameText.Text = "";
                PasswordText.Text = "";
                SecretMessageText.Text = "";
            }

        }
        
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}