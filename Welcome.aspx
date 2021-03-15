<%@ Page Title="" Language="C#" MasterPageFile="~/childMaster.master" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="MasterPagesDemo.Welcome" EnableTheming="true" Theme="BirthdayTheme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <p>
        Select Value:
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>iphone</asp:ListItem>
            <asp:ListItem>macbook</asp:ListItem>
            <asp:ListItem>ipad</asp:ListItem>
            <asp:ListItem>laptop</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server" SkinID="bluetext"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
