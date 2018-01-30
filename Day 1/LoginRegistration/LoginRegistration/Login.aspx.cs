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
    public partial class Login : System.Web.UI.Page
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["TempConnectionString1"].ConnectionString))
                {

                    connectionString.Open();
                    string id, password;                    
                    id = UserIDText.Text;
                    password = PasswordText.Text;
                    if (id == "" || password == "")
                    {
                        message.Attributes.Add("class", "alert-warning");
                        message.Text = "Please fill all the details";
                        //Response.Write("<script language=javascript>alert('Please fill all the details')</script>");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connectionString;
                        cmd.CommandText = "USP_SearchUserDetails";

                        cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = id;                       
                        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataReader rd = cmd.ExecuteReader();
                      
                        if (rd.HasRows)
                        {
                            //message.Attributes.Add("class", "alert-success");
                            //message.Text = "Login Successful";

                            //Response.Write("<script language=javascript>alert('Insertion Successful')</script>");
                            //UserIDText.Text = "";                            
                            //PasswordText.Text = "";
                            //rd.Read();
                            Session["UserID"] = id;
                            //Session["UserName"] = rd["UserName"];
                            Response.Redirect("Home.aspx");
                        }
                        else
                            throw (new Exception());
                    }
                }
            }
            
            catch (Exception)
            {
                message.Attributes.Add("class", "alert-danger");
                message.Text = "Wrong User ID or Password";
                //Response.Write("<script language=javascript>alert('Error Occurred')</script>");
                UserIDText.Text = "";
                PasswordText.Text = "";
            }
        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx");
        }
    }
}