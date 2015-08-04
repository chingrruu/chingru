<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParentRegister.aspx.cs" Inherits="dwa_chk1.WebForm1" %>

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
            margin-left: 0px;
        }
        .auto-style6 {
            width: 200px;
            font-size: x-large;
        }
        .auto-style5 {
            width: 200px;
        }
        .auto-style11 {
            width: 200px;
            height: 26px;
        }
        .auto-style12 {
            height: 26px;
        }
        .auto-style9 {
            width: 200px;
            height: 30px;
        }
        .auto-style10 {
            height: 30px;
        }
        .auto-style7 {
            width: 200px;
            height: 28px;
        }
        .auto-style8 {
            height: 28px;
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
            <td class="auto-style5">Salutation</td>
            <td>
                <asp:DropDownList ID="ddlSalutation" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" style="width: 128px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" Display="Dynamic" ErrorMessage="Please specify a name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">Contact Number</td>
            <td class="auto-style12">
                <asp:TextBox ID="txtTelNo" runat="server" style="width: 128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Email Address</td>
            <td class="auto-style10">
                <asp:TextBox ID="txtEmailAddr" runat="server" Width="128px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmailAddr" Display="Dynamic" ErrorMessage="Please specify a valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <asp:CustomValidator ID="cuvEmail" runat="server" ControlToValidate="txtEmailAddr" Display="Dynamic" ErrorMessage="Email has been used!" ForeColor="Red" OnServerValidate="cuvEmail_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" Width="127px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Please enter a password" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="covPassword" runat="server" ControlToCompare="txtConfirmPassword" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Please enter the correct password!" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Confirm Password</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtConfirmPassword" runat="server" style="width: 128px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Address</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" style="width: 128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>
                <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
