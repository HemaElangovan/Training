<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControls.aspx.cs" Inherits="Task_D16.WebControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET</title>
    <style>
        .btnClass
        {
            background-color : forestgreen;
        }
        .btnClass:hover
        {
            background-color : yellow;
        }
    </style>
</head>
<body>   
    <form id="form1" runat="server">
        <center><h2>Web Controls</h2></center>
        <div>
            <asp:Label ID="Hello_lbl" runat="server" Text="Hello!!"></asp:Label>
            <br />
            <br />
            <center>
                <asp:Button ID="Clickme_btn" class="btnClass" runat="server" Text="Click me" OnClick="Clickme_btn_Click" />
                <br />
                <br />
                <asp:Label ID="Clickme_lbl" runat="server"></asp:Label>
            </center>        
                <br />
                <br />                
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Check Box" />
            <br />
            <br />            
        </div>
    </form>
</body>
</html>
