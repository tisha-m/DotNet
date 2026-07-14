<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Example.WebForm2" UnobtrusiveValidationMode = "None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Registration Form<br />
            <br />
            <asp:Label ID="Name" runat="server" Text="Name:"></asp:Label>
&nbsp;
            <asp:TextBox ID="NameTxt" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="NameValidator" runat="server" ControlToValidate="NameTxt" ErrorMessage="Name is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Password" runat="server" Text="Password:"></asp:Label>
&nbsp;
            <asp:TextBox ID="PasswordTxt" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordValidator" runat="server" ControlToValidate="PasswordTxt" ErrorMessage="Password is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="ConfirmPass" runat="server" Text="Confirm Password:"></asp:Label>
&nbsp;
            <asp:TextBox ID="ConfirmPassTxt" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="ConfirmPassValidator" runat="server" ControlToCompare="PasswordTxt" ControlToValidate="ConfirmPassTxt" ErrorMessage="Password is not same" ForeColor="#FF3300"></asp:CompareValidator>
            <br />
            <br />
            <asp:Label ID="Mail" runat="server" Text="E-mail:"></asp:Label>
&nbsp;
            <asp:TextBox ID="MailTxt" runat="server" TextMode="Email"></asp:TextBox>
            <asp:RegularExpressionValidator ID="MailValidator" runat="server" ControlToValidate="MailTxt" ErrorMessage="Invalid email" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="MobileNo" runat="server" Text="Mobile No.:"></asp:Label>
&nbsp;
            <asp:TextBox ID="MobileNoTxt" runat="server" TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="MobileNoTxt" ErrorMessage="Mobile Number is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="MobileNoTxt" ErrorMessage="It must be 10 digits" ForeColor="#FF3300" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="Gender" runat="server" Text="Gender:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="Male" runat="server" Text="Male" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="Female" runat="server" Text="Female" />
            <br />
            <br />
            <asp:Button ID="Submit" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
