<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonImage.aspx.cs" Inherits="Task_D16.ButtonImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Click any of the three images to display it at the bottom"></asp:Label>
            <br />
            <br />

        </div>
        <asp:ImageButton ID="imgbtn_Oval" runat="server" Height="140px" ImageUrl="~/Images/oval.png" OnClick="imgbtn_Oval_Click" Width="253px" />
        <asp:ImageButton ID="imgbtn_Rectangle" runat="server" ImageUrl="~/Images/rectangle.png" OnClick="imgbtn_Rectangle_Click" />
        <asp:ImageButton ID="imgbtn_Triangle" runat="server" ImageUrl="~/Images/triangle.png" OnClick="imgbtn_Triangle_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Click on bottom image to clear it"></asp:Label>
        <br />
        <br />
        <asp:ImageButton ID="imgbtn_Bottom" runat="server" OnClick="imgbtn_Bottom_Click" />
        <br />
    </form>
</body>
</html>
