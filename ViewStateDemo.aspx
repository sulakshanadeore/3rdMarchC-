<%@ Page Language="C#" Trace="true" AutoEventWireup="true" CodeBehind="ViewStateDemo.aspx.cs" Inherits="StateMgtDemo.ViewStateDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Enter Name
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Store Data in View State" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Retrieve Data from View State" />
        <br />
        <br />
        The data in the ViewState : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <hr />
        <p>
            No of hits :
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="click here to know number of hits" />
        </p>
    </form>
</body>
</html>
