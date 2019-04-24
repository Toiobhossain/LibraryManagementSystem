<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Book_page.aspx.cs" Inherits="Library_management_System.Book_page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <h1>Insert Book Information</h1>
    <br />
    <table>
       
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Book Name"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextName" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Book authore name"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextAuName" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Book publication Name"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextpuName" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Book Purchare Date"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextpuDate" runat="server" Width="183px"></asp:TextBox>
                

            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Calender" OnClick="Button1_Click" Width="77px" BackColor="#990000" ForeColor="White" />

            </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text=" "></asp:Label>

                </td>
            <td>
                <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Visible="False" Width="220px" OnSelectionChanged="Calendar1_SelectionChanged">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Book Price"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextPrice" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                     <asp:Label ID="Label6" runat="server" Text="Book quantity"></asp:Label>
            </td>
       <td>
           <asp:TextBox ID="TextQuantity" runat="server"></asp:TextBox>

       </td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text=" "></asp:Label>

            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Submit" BackColor="Lime" ForeColor="White" Height="30px" OnClick="Button2_Click" Width="119px" />

            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Clear" BackColor="Lime" ForeColor="White" Height="28px" OnClick="Button3_Click" Width="82px" />

            </td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="lblmsg" runat="server" Text=" " ForeColor="#33CC33"></asp:Label>
               

            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <asp:Button ID="Button4" runat="server" Text="Go to Home" BackColor="Lime" ForeColor="Red" Height="33px" OnClick="Button4_Click" Width="145px" />

            </td>
        </tr>
        
    </table>
</asp:Content>
