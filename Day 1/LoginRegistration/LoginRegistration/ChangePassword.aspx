<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="LoginRegistration.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="style/style1.css" rel="stylesheet" />
    <title>Change Password</title>
</head>
<body>
    <div class="container">
        <asp:Label ID="message" runat="server" class="alert"></asp:Label><br />
        <br />
        <div class="panel panel-primary">

            <div class="panel-heading">
                Change Password
            </div>
            <div class="panel-body">
                <form id="form2" runat="server">
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Enter New Password"></asp:Label>
                        <asp:TextBox ID="Password2" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Confirm New Password"></asp:Label>
                        <asp:TextBox ID="Password1" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                    </div>
                    <asp:Button ID="SetPassword" runat="server" OnClick="Button1_Click" Text="Change Password" class="btn btn-primary" />
                    
                    <br /><br />
                    <asp:Button ID="SignInButton" runat="server" OnClick="Button2_Click1" Text="Sign In" />
            
                </form>
            </div>
        </div>
    </div>
</body>
</html>
