<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginFrom.aspx.cs" Inherits="Library_management_System.LoginFrom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <h1> Login From</h1>
    <br />
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextName" runat="server"></asp:TextBox>

            </td>
           </tr>
           </table>
           <br />
           <table>
           <tr>
            <td style="width: 69px">
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextPassword" runat="server" TextMode="Password"></asp:TextBox>

            </td>
        </tr>
        </table>
        <br />
        <table>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="      "></asp:Label>
                
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Login" BackColor="#33CC33" ForeColor="White" OnClick="Button1_Click" Width="100px" />
                

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblmsg" runat="server" Text="   " ForeColor="Red"></asp:Label>

            </td>
        </tr>
    </table>
</asp:Content>
