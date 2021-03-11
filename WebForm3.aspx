<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="FirstWebApplication.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function f1() {
            alert('hello');
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="90px" ImageUrl="~/Images/subtractimage.png" OnClick="ImageButton1_Click" ToolTip="Subtract" Width="141px" />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Multiply</asp:LinkButton>
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

        <asp:FileUpload ID="FileUpload1" runat="server" /><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>


        <br />
        <br />
        <input id="Button2" type="button" value="button" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Button" />

        <input id="Submit1" type="submit" value="HTML Submit" onclick="f1()" />

    </form>
</body>
</html>
