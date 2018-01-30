<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="LoginRegistration.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <title>Registration Form</title>
    <link href="style/style1.css" rel="stylesheet" />
        
</head>
<body>  
        
        
    
    <div class="container">
        
                    <asp:Label ID="message" runat="server" class="alert"></asp:Label><br /><br />
                
        <div class="panel panel-primary">

            <div class="panel-heading">
                
                Registration Form
            </div>
            <div class="panel-body">
                <form id="form2" runat="server">
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="User ID"></asp:Label>
                        <asp:TextBox ID="UserIDText" runat="server" class="form-control" ></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="User Name"></asp:Label>
                        <asp:TextBox ID="UserNameText" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>
                        <asp:TextBox ID="PasswordText" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label4" runat="server" Text="Secret Message"></asp:Label>
                        <asp:TextBox ID="SecretMessageText" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                    <asp:Button ID="SubmitButton" runat="server" OnClick="Button1_Click" Text="Submit" class="btn btn-primary" />
                    <br /><br />
            <asp:Button ID="SignInButton" runat="server" OnClick="Button1_Click1" Text="Sign In" />
            

                </form>
            </div>
            
        </div>

    </div>


</body>
</html>
