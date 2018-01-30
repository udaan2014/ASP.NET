<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="LoginRegistration.UpdateProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="style/style1.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Label ID="message" runat="server" class="alert"></asp:Label><br /><br />
        <div class="panel panel-primary">

            <div class="panel-heading">
                Profile Info
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-4"></div>
                    <div id="profilePic" class="col-md-4">   
                                      
                        <asp:Image runat="server" alt='Profile Pic' height='100' width='100' id="pic"/>
                    </div>
                    <div class="col-md-4"></div>
                </div>
                <br />
                <div class="row form-group">
                    <div class="col-md-4">
                        User ID:

                    </div>
                    <div class="col-md-8">
                        <asp:Label ID="UserIDLabel" runat="server" Text="UserID"></asp:Label><br />
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-md-4">
                         User Name:
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="UserNameText" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-md-4">
                        Password:
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="PasswordText" runat="server" class="form-control" ></asp:TextBox>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-md-4">
                        Secret Message:
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="SecretMessageText" runat="server" class="form-control" ></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Button ID="UpdateButton" runat="server" OnClick="Button1_Click" Text="Update Details" class="btn btn-primary" />
                   
                </div>
        </div>
    </div>


    </div>

</asp:Content>
