<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="FirstWebApplication.WebForm7" %>

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
            Select The Profile View:
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Select Appropriate View</asp:ListItem>
                <asp:ListItem>Personal</asp:ListItem>
                <asp:ListItem>Educational</asp:ListItem>
                <asp:ListItem>Experience</asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="Personal" runat="server">This is personal view<br />
                <br />
                Enter Name:
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                Enter Date of Birth:
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                <br />
                Age:
                <asp:TextBox ID="txtage" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                <br />
                City:
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="Mumbai"></asp:ListItem>
                    <asp:ListItem Value="Bangalore"></asp:ListItem>
                    <asp:ListItem>Hyderabad</asp:ListItem>
                </asp:DropDownList>
                <br />
                Do u have a Passport:
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="passport" Text="Yes" />
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="passport" Text="No" />
                <br />
                <br />
                <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" />
                <br />
            </asp:View>
            <asp:View ID="Education" runat="server">This is Educational view<br />
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
                    <asp:Button ID="btnNextExp" runat="server" Text="Next" />
                </p>
            </asp:View>
            <asp:View ID="JobExperience" runat="server">This is job experience view<br />
                <br />
                <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True">
                    <asp:ListItem>IBM</asp:ListItem>
                    <asp:ListItem>Cognizant</asp:ListItem>
                    <asp:ListItem Value="LNT"></asp:ListItem>
                </asp:ListBox>
                &nbsp;&nbsp;
                <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
            </asp:View>
        </asp:MultiView>
    </form>
</body>
</html>
