﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ServiceClientTrial.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Call Service" />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:ListBox ID="ListBox1" runat="server" Height="140px" Width="362px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
