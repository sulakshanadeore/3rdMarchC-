<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MasterPagesDemo.Login" EnableTheming="true" Theme="Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="margin-left: 40px">
    <br />
&nbsp;</p>
<p style="margin-left: 40px">
    &nbsp;</p>
<table class="auto-style1">
    <tr>
        <td style="width: 250px">Enter UserName: </td>
        <td>
            <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 250px">Enter Password: </td>
        <td>
            <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 250px">&nbsp;</td>
        <td>
            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" style="height: 26px" Text="Login" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" PostBackUrl="~/Home.aspx" Text="Cancel" />
        </td>
    </tr>
</table>
<p>
</p>
</asp:Content>
