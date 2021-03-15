<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="StateMgtDemo.Registration" %>

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
        <div class="auto-style1">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Welcome.aspx">Click here to move ahead</asp:LinkButton>
        </div>
        <p>
            Enter CustomerID :&nbsp;
            <asp:TextBox ID="txtcustid" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter CustomerName:<asp:TextBox ID="txtcustname" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Move Ahead" />
    </form>
</body>
</html>
