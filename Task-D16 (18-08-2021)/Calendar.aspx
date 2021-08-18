<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="Task_D16.Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          
            <asp:Calendar ID="Calendar1" runat="server" BorderStyle="Inset" BorderWidth="10px" CellPadding="1" CellSpacing="4" Height="300px" Width="500px" FirstDayOfWeek="Saturday" SelectedDate="2021-08-24" SelectionMode="DayWeekMonth">
                <DayStyle ForeColor="#993333" />
                <NextPrevStyle ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#66FFFF" ForeColor="Black" />
                <SelectorStyle ForeColor="#00FF99" />
                <TitleStyle BackColor="#009933" Font-Bold="True" ForeColor="White" />
                <TodayDayStyle BackColor="#33CCFF" Font-Bold="True" />
            </asp:Calendar>

        </div>
    </form>
</body>
</html>
