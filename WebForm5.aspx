<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="FirstWebApplication.WebForm5" %>

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
            Select Date:&nbsp;&nbsp;
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        </p>
        <p>
            <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
        </p>
        <p>
            Select One/Many :
            <asp:ListBox ID="Products_list" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Products_list_SelectedIndexChanged">
                <asp:ListItem Value="50">Milk</asp:ListItem>
                <asp:ListItem Value="40">Butter</asp:ListItem>
                <asp:ListItem Value="40">Bread</asp:ListItem>
                <asp:ListItem Value="20">Jam</asp:ListItem>
                <asp:ListItem Value="100">Cheese</asp:ListItem>
            </asp:ListBox>
&nbsp;
        </p>
        <p>
            Select qty:&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem Value="3"></asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:TextBox ID="txtcart" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
