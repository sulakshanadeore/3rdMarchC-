<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCustomer.aspx.cs" Inherits="DeclarativeDemo.CreateCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                Enter Customerid:
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                Enter CustomerName:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                Enter City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create" />
                <asp:Button ID="Button2" runat="server" Text="Button" />
                <asp:Button ID="Button3" runat="server" Text="Button" />
                <asp:Button ID="Button4" runat="server" Text="Button" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
