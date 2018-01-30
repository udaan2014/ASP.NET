<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="LoginRegistration.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="style/style1.css" rel="stylesheet" />
    <title>Forgot Password</title>
</head>
<body>

    <div class="container">

        <asp:Label ID="message" runat="server" class="alert"></asp:Label><br />
        <br />

        <div class="panel panel-primary">

            <div class="panel-heading">
                Forgot Password
            </div>
            <div class="panel-body">
                <form id="form2" runat="server">
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="User ID"></asp:Label>
                        <asp:TextBox ID="UserIDText" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Secret Message "></asp:Label>
                        <asp:TextBox ID="SecretMessageText" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                    </div>
                    <asp:Button ID="CheckSecretButton" runat="server" OnClick="Button1_Click" Text="Submit" class="btn btn-primary" />
                    
                    
                    <br /><br />
                    <asp:Button ID="SignInButton" runat="server" OnClick="Button2_Click1" Text="Sign In" />
                    <asp:Button ID="RegisterButton" runat="server" OnClick="Button3_Click1" Text="Register New User" />
            
                </form>
            </div>
        </div>
    </div>

</body>
</html>
