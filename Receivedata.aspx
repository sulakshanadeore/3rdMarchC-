<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Receivedata.aspx.cs" Inherits="StateMgtDemo.Receivedata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Button" />
        <br />
        Customer ID: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Customer Name:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Customer City:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
    </form>
</body>
</html>
