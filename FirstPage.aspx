<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="LoginLogoutProject.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <center> <asp:Label ID="Label1" runat="server" ForeColor="#660066" Font-Size="50px" Text="Demo Login Logout Flow"></asp:Label></center>
        <br />
        <br />
        <br />
        <center>
        <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="TextBox2" type="password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LogIn" />
        </center>
    </form>
</body>
</html>
