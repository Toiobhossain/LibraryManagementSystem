<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Library_management_System.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <h1>Registration From</h1>
    <br />
    <table>
    <tr>
        <td style="width: 111px">
            <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="TextFname" runat="server"></asp:TextBox>

        </td>
        
        <td>
            <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="TextLname" runat="server"></asp:TextBox>

        </td>
    </tr>
        <tr>
            <td style="width: 111px">
                <asp:Label ID="Label2" runat="server" Text="Full Name"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextFullname" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="width: 111px">
                <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextPassword" runat="server" TextMode="Password"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="width: 111px">
                 <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
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
            <td style="width: 111px">
                <asp:Label ID="Label6" runat="server" Text="Phone Number"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="TextPhone" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="width: 111px">
                <asp:Label ID="Label7" runat="server" Text="City"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownListCity" runat="server">
                    <asp:ListItem>Select item</asp:ListItem>
                    <asp:ListItem>Comilla</asp:ListItem>
                    <asp:ListItem>Dhaka</asp:ListItem>
                    <asp:ListItem>Chittagong</asp:ListItem>
                    <asp:ListItem>khulna</asp:ListItem>
                    <asp:ListItem>Mymensingh</asp:ListItem>
                    <asp:ListItem>Rajshahi</asp:ListItem>
                    <asp:ListItem>Rangpur</asp:ListItem>
                    <asp:ListItem>Sylhet</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
        </table>
    <br />
        <table>
        <tr>
            <td style="width: 111px">
                <asp:Label ID="Label8" runat="server" Text=" "></asp:Label>

            </td>
           
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="#00CC00" BorderColor="Red" ForeColor="White" OnClick="Button1_Click" Width="139px" Height="30px" />

            </td>
            <td>
                <asp:Label ID="Label10" runat="server" Text=" "></asp:Label>

            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Clear" BackColor="#00CC00" BorderColor="Red" ForeColor="White" Height="30px" Width="75px" OnClick="Button3_Click" />

            </td>
        </tr>
        <tr>
            <td style="width: 111px">
                <asp:Label ID="lblmsg" runat="server" Text=" " ForeColor="#009933"></asp:Label>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text=" "></asp:Label>

            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Login with Library" BackColor="Lime" BorderColor="Red" ForeColor="Red" Height="44px" OnClick="Button2_Click" Width="231px" />

            </td>
        </tr>
    </table>
</asp:Content>
