<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmRegistration.aspx.cs" Inherits="dwa_chk1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style3 {
            width: 823px;
            height: 213px;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style6 {
            width: 200px;
            font-size: x-large;
        }
        .auto-style5 {
            width: 200px;
        }
        .auto-style9 {
            width: 200px;
            height: 25px;
        }
        .auto-style10 {
            height: 25px;
        }
        .auto-style11 {
            width: 200px;
            height: 23px;
        }
        .auto-style12 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
                    <asp:HyperLink ID="lnkMainPage" runat="server" Font-Bold="True" Font-Names="Imprint MT Shadow" Font-Size="40px" NavigateUrl="Main.aspx" ForeColor="#009933">NP Tuition Centre</asp:HyperLink>
                    <br />
                    <img alt="" class="auto-style3" src="Images/NP%20Tution%20Centre%20Logo.JPG" /><table class="auto-style4">
        <tr>
            <td class="auto-style6"><strong>Parent Register</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Salutation</td>
            <td class="auto-style12">
                <asp:Label ID="lblSalutation" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Name</td>
            <td>
                <asp:Label ID="lblName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Contact Number</td>
            <td>
                <asp:Label ID="lblTelNo" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Email Address</td>
            <td>
                <asp:Label ID="lblEmailAddr" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Password</td>
            <td>
                <asp:Label ID="lblPassword" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Confirm Password</td>
            <td class="auto-style10">
                <asp:Label ID="lblConfirmPassword" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Address</td>
            <td>
                <asp:Label ID="lblAddress" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
                <br />
            </td>
            <td>
                <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />
                <br />
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblMessage2" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
