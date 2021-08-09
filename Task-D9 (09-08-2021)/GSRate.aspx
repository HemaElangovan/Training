<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GSRate.aspx.cs" Inherits="D9_Task.GSRate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="GS_ddl" runat="server">
            <asp:ListItem>Gold</asp:ListItem>
            <asp:ListItem>Silver</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <br />
        <br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        <br />
        <div>

            <asp:Button ID="Btn_ViewRate" runat="server" OnClick="Btn_ViewRate_Click" Text="View Rate" />

        </div>
    </form>
</body>
</html>
