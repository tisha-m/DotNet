<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Database.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        User Login</p>
    <p>
        Email:
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
    </p>
    <p>
        Password: <asp:TextBox ID="pwd" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="signIn" runat="server" Text="Sign in" />
    </p>
</asp:Content>
