<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shopping.aspx.cs" Inherits="Task_D16.Shopping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />
            <asp:ListBox ID="Groceries_lb1" runat="server" OnLoad="Groceries_lb1_Load">
                <asp:ListItem>Hand Wash</asp:ListItem>
                <asp:ListItem>Sanitizer</asp:ListItem>
                <asp:ListItem>Pasta</asp:ListItem>
                <asp:ListItem>Rice</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Item" />
            <br />
            
            <asp:Image ID="img_hw" runat="server" ImageUrl="~/Images/hw.jfif" Visible="False" />
            <asp:Image ID="img_san" runat="server" ImageUrl="~/Images/san.jfif" Visible="False" />
            <br />
            <asp:Image ID="img_pasta" runat="server" ImageUrl="~/Images/pasta.jfif" Visible="False" />
            <asp:Image ID="img_rice" runat="server" ImageUrl="~/Images/rice.jfif" Visible="False" />
            <br />
                <br />
                <asp:Label ID="Cost_lbl2" runat="server" Visible="False">Cost </asp:Label>
           
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Cost_lbl" runat="server"></asp:Label>
           
            <br />
            <asp:Label ID="qtn_lbl" runat="server" Text="Enter the quantity"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="qtn_txt" runat="server" Width="146px"></asp:TextBox> &nbsp
            <asp:Button ID="btn_TotPrice" runat="server" OnClick="btn_TotPrice_Click" Text="View Total Price" Height="27px" Width="168px" />
            <br />
            <br />
            <asp:Label ID="TotPrice_lbl" runat="server" Text="Total Cost" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
           
        </div>
    </form>
</body>
</html>
