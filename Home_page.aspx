<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home_page.aspx.cs" Inherits="Library_management_System.Home_page1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <table>
        <tr>
            <td style="height: 22px">
                <asp:Label ID="Label1" runat="server" Text="Home page" BackColor="#33CC33"></asp:Label>

            </td>
            <td style="height: 22px">
                <asp:Label ID="Label2" runat="server" Text="Home page" BackColor="#FF3300"></asp:Label>

            </td>
            <td style="height: 22px">
                <asp:Label ID="Label3" runat="server" Text="Home page" BackColor="#33CC33"></asp:Label>

            </td>
            <td style="height: 22px">
                <asp:Label ID="Label4" runat="server" Text="Home page" BackColor="#FF3300"></asp:Label>

            </td>
            <td style="height: 22px">
                <asp:Label ID="Label5" runat="server" Text="Home page" BackColor="#33CC33"></asp:Label>
            </td>
            <td style="height: 22px">
                <asp:Label ID="Label6" runat="server" Text="Home page" BackColor="Red"></asp:Label>
            </td>
            <td style="height: 22px">
                <asp:Label ID="Label7" runat="server" Text="Home page" BackColor="#33CC33"></asp:Label>
            </td>
            <td style="height: 22px">
                 <asp:Label ID="Label8" runat="server" Text="Home page" BackColor="Red"></asp:Label>

            </td>
            <td style="height: 22px">
                 <asp:Label ID="Label9" runat="server" Text="Home page" BackColor="#33CC33"></asp:Label>
            </td>
            <td style="height: 22px">
                 <asp:Label ID="Label10" runat="server" Text="Home page" BackColor="Red"></asp:Label>
            </td>
            <td style="height: 22px">
                 <asp:Label ID="Label11" runat="server" Text="Home page" BackColor="#33CC33"></asp:Label>
            </td>
            <td style="height: 22px">
                 <asp:Label ID="Label12" runat="server" Text="Home page" BackColor="Red"></asp:Label>
            </td>
            <td>
                 <asp:Label ID="Label13" runat="server" Text="Home page" BackColor="Lime" ForeColor="Black"></asp:Label>
            </td>
        </tr>
    </table>
    

    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">

    </asp:ScriptManagerProxy>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>
    <asp:Image ID="Image1" runat="server" Height="32px" Width="335px" ImageUrl="~/1_YLlZ96J3p8GFkIh1USVMzg.jpeg" />
    <asp:Image ID="Image2" runat="server" Height="32px" Width="335px" ImageUrl="~/A-Good-Lifetime-Habit-Read-More-Books-to-Expand-Your-Sense-of-Life---.jpg" />
    <asp:Image ID="Image3" runat="server" Height="32px" Width="295px" ImageUrl="~/books-bookstore-book-reading-159711.jpeg" />
       
 
    <br />
    <table>
        <tr>
            <td>
                <asp:Button ID="Button8" runat="server" Text="<<" OnClick="Button8_Click" />

            </td>
            <td>
                <asp:Button ID="Button9" runat="server" Text=">>" OnClick="Button9_Click" />
            </td>
        </tr>
    </table>
     </ContentTemplate>
    </asp:UpdatePanel>
    <table>
        <tr>
            <td style="width: 233px">
                <asp:Button ID="Button1" runat="server" Text="Insert Book Information" Width="239px" BackColor="Lime" BorderColor="White" BorderStyle="Dotted" ForeColor="White" OnClick="Button1_Click" />

            </td>

        </tr>
        <tr>
            <td style="width: 233px">
                <asp:Button ID="Button2" runat="server" Text="Insert Student Information" Width="239px" BackColor="Lime" BorderColor="White" BorderStyle="Dotted" ForeColor="White" OnClick="Button2_Click" />

            </td>
        </tr>
        <tr>
            <td style="width: 233px">
                <asp:Button ID="Button3" runat="server" Text="Show Book Information" Width="240px" BackColor="Lime" BorderColor="White" BorderStyle="Dotted" ForeColor="White" OnClick="Button3_Click" />

            </td>
        </tr>
        <tr>
            <td style="width: 233px">
                <asp:Button ID="Button4" runat="server" Text="Show Student Information" Width="239px" BackColor="Lime" BorderColor="White" BorderStyle="Dotted" ForeColor="White" OnClick="Button4_Click" />

            </td>
        </tr>
        <tr>
            <td>
                  <asp:Button ID="Button5" runat="server" Text="Show borrow Book Information" Width="239px" BackColor="Lime" BorderColor="White" BorderStyle="Dotted" ForeColor="White" OnClick="Button5_Click" />
            </td>
          

        </tr>
        <tr>
            <td style="width: 233px">
                <asp:Button ID="Button6" runat="server" Text="Update Information" Width="240px" BackColor="Lime" BorderColor="White" BorderStyle="Dotted" ForeColor="White" OnClick="Button6_Click" />

            </td>
        </tr>
        <tr>
            <td style="width: 233px">
                <asp:Button ID="Button7" runat="server" Text="Delete Information" Width="239px" BackColor="Lime" BorderColor="White" BorderStyle="Dotted" ForeColor="White" OnClick="Button7_Click" />

            </td>
        </tr>
    </table>
</asp:Content>
