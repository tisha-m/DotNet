<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StudentRecord.aspx.cs" Inherits="Database.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Student Record</p>
    <p>
        Name
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
    </p>
    <p>
        Branch
        <asp:TextBox ID="branch" runat="server"></asp:TextBox>
    </p>
    <p>
        Sem
        <asp:TextBox ID="sem" runat="server"></asp:TextBox>
    </p>
    <p>
        City
        <asp:DropDownList ID="city" runat="server">
            <asp:ListItem>Porbandar</asp:ListItem>
            <asp:ListItem>Rajkot</asp:ListItem>
            <asp:ListItem>Ahmedabad</asp:ListItem>
            <asp:ListItem>Bhuj</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Gender
        <asp:RadioButtonList ID="gender" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
    </p>
</asp:Content>
