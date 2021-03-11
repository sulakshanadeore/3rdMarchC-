<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="FirstWebApplication.WebForm2" %>

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
            <asp:Label ID="Label1" runat="server" Text="Enter UserName"></asp:Label>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Enter Empno"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtempno" runat="server" Width="125px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtdisplayname" runat="server" BackColor="#66FF33" ForeColor="#FF66FF" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnUserLogin" runat="server" BackColor="#CCFF33" Font-Bold="True" Font-Size="Larger" ForeColor="#FF6666" OnClick="Button1_Click" Text="Login" />


        &nbsp;<asp:Button ID="btncancel" runat="server" OnClick="btncancel_Click" Text="Cancel" />


        </p>
        <p>
            <asp:TextBox ID="txtdata" runat="server"></asp:TextBox>


        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Image ID="Image1" Height="200" Width="200" BorderStyle="Dotted" BorderWidth="5px" BorderColor="Red" runat="server" />
            <asp:Image ID="Image2" Height="200" Width="300" runat="server" />


        </p>
    </form>
</body>
</html>
