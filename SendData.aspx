<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendData.aspx.cs" Inherits="StateMgtDemo.SendData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 480px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div class="auto-style1">
            Session ID:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome,
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <p>
            Enter CustomerID :&nbsp; <asp:TextBox ID="txtcustid" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter CustomerName:<asp:TextBox ID="txtcustname" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter City:
            <asp:TextBox ID="txtcustcity" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Move Ahead" />
    </form>
</body>
</html>
