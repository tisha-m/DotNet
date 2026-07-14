<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:RadioButton ID="Male" runat="server" OnCheckedChanged="Male_CheckedChanged" Text="Male" GroupName="Gender" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="Female" runat="server" OnCheckedChanged="Female_CheckedChanged" Text="Female" GroupName="Gender" />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:CheckBox ID="C" runat="server" Text="C" AutoPostBack="True" />
            <br />
            <asp:CheckBox ID="Csharp" runat="server" Text="C#" AutoPostBack="True" />
            <br />
            <asp:CheckBox ID="Java" runat="server" Text="Java" AutoPostBack="True" />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem>Rajkot</asp:ListItem>
                <asp:ListItem>Porbandar</asp:ListItem>
                <asp:ListItem>Bhuj</asp:ListItem>
                <asp:ListItem>Ahmedabad</asp:ListItem>
                <asp:ListItem>Morbi</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
