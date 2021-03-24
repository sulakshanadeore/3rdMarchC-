<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" style="height: 26px" />
            <asp:Button ID="Button4" runat="server" Text="Find" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="Show" OnClick="Button5_Click" />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
