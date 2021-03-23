<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DeclarativeDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table style="border:double;border-style:dashed">
                            <tr>
                            <td><b>CustomerID</b></td>
                                                     
                            <td><b>CustomerName</b></td>
                            
                            
                            <td><b>CustomerCity</b></td>
                            </tr>

                </HeaderTemplate>
                <ItemTemplate>
                    <tr style="border-color:blue;border-style:solid;background-color:pink">
                        <td>
                            <%#Eval("CustId") %>
                        </td>
                        <td>
                            <%#Eval("CompanyName") %>
                        </td>
                        <td>
                            <%#Eval("City") %>
                        </td>
                    </tr>
                        
                    
                    

                </ItemTemplate>
                <SeparatorTemplate>
                    <td><hr /></td>
                    <td><hr /></td>
                    <td><hr /></td>
                </SeparatorTemplate>
                <AlternatingItemTemplate>
                    <tr style="border-color:red;border-style:solid;background-color:aqua">
                        <td>
                            <%#Eval("CustId") %>
                        </td>
                        <td>
                            <%#Eval("CompanyName") %>
                        </td>
                        <td>
                            <%#Eval("City") %>
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <SeparatorTemplate>
                    <td><hr /></td>
                    <td><hr /></td>
                    <td><hr /></td>
                </SeparatorTemplate>
                <FooterTemplate>
                    <center>
                    <tr><td>Customer Records</td></tr>
                        </center>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
