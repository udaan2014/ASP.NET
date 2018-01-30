<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginRegistration.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <title>Login Form</title>
    <link href="style/style1.css" rel="stylesheet" />
</head>
<body>

    <div class="container">

        <asp:Label ID="message" runat="server" class="alert"></asp:Label><br /><br />

        <div class="panel panel-primary">
            <div class="panel-heading">
                Login Form
            </div>
            <div class="panel-body">
                <form id="form2" runat="server">
                    <div class="form-group">                                               
                       <asp:Label ID="Label2" runat="server" Text="User ID"></asp:Label>
                       <asp:TextBox ID="UserIDText" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Password "></asp:Label>
                        <asp:TextBox ID="PasswordText" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                    </div>

                    <asp:Button ID="LoginButton" runat="server" OnClick="Button1_Click" Text="Login" class="btn btn-primary" />
                    <br /><br />
                    <asp:Button ID="RegisterButton" runat="server" OnClick="Button2_Click" Text="Register New User" />
                    <asp:Button ID="ForgotButton" runat="server" OnClick="Button3_Click" Text="Forgot Password" />
                </form>
            </div>





        </div>

    </div>
</body>
</html>
