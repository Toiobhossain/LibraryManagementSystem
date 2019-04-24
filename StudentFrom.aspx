<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentFrom.aspx.cs" Inherits="Library_management_System.StudentFrom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <h1>
        Insert Student Information
    </h1>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Student ID"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextID" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Student Name"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextName" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Department"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextDepartment" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Phone Number"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextNumber" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextAddress" runat="server"></asp:TextBox>

            </td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Gender"></asp:Label>

            </td>
            <td>
                <asp:DropDownList ID="DropDownListGender" runat="server">
                    <asp:ListItem>Select item</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Student Image"></asp:Label>

            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Book ID"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextBookId" runat="server"></asp:TextBox>

            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text=" "></asp:Label>

            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="Lime" ForeColor="White" Width="99px" OnClick="Button1_Click" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Clear" BackColor="Lime" ForeColor="White" Height="28px" OnClick="Button2_Click" Width="78px" />

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblmsg" runat="server" Text=" " ForeColor="#00CC00"></asp:Label>

            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Go to Home" BackColor="Lime" BorderColor="Lime" ForeColor="Red" Height="33px" OnClick="Button3_Click" Width="130px" />

            </td>
        </tr>
    </table>
</asp:Content>
