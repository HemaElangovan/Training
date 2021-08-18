<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advertisements.aspx.cs" Inherits="Task_D16.Advertisements" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <asp:LinkButton ID="Amazon_lbtn" runat="server" BorderWidth="5px" Font-Size="Small" Height="80px" OnClick="Amazon_lbtn_Click" Width="60px">Amazon</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="Fabmart_lbtn" runat="server" BorderWidth="5px" Font-Size="Small" Height="80px" OnClick="Fabmart_lbtn_Click" Width="60px">Fabmart</asp:LinkButton>
            </center>
        </div>
    </form>
</body>
</html>
