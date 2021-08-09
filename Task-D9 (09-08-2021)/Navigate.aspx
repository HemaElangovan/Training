    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navigate.aspx.cs" Inherits="D9_Task.Navigate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DropDownList ID="Menu_ddl" runat="server" Height="18px" OnLoad="Menu_ddl_Load" Width="127px">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Button ID="btn1_Submit" runat="server" OnClick="btn1_Submit_Click" Text="Click here to view items" />

        </div>
    </form>
</body>
</html>
