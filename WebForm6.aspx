<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="FirstWebApplication.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div>
        </div>
        <p>
            Enter Name:
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            Upload File :
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
        <p>
            Upload your photo here
            <asp:FileUpload ID="FileUpload2" runat="server" />
&nbsp;<asp:Image ID="Image1" runat="server" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show Uploaded Image" />
        </p>
        <p>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>VB</asp:ListItem>
                <asp:ListItem>Java</asp:ListItem>
                <asp:ListItem Value="Python"></asp:ListItem>
            </asp:CheckBoxList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
