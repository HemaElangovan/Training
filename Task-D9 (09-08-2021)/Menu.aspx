<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="D9_Task.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            

            <asp:ListBox ID="Menu_lb1" runat="server"></asp:ListBox>

            

            <br />
            <br />
            <asp:Button ID="Btn_Back" runat="server" OnClick="Btn_Back_Click" Text="Back" />
            <br />

            

        </div>
    </form>
</body>
</html>
