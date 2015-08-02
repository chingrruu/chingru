<%@ Page Title="" Language="C#" MasterPageFile="~/Tutor.Master" AutoEventWireup="true" CodeBehind="viewinfo.aspx.cs" Inherits="dwa_chk1.viewinfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style75 {
            width: 823px;
            height: 213px;
        }
        .auto-style76 {
            width: 223px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <img alt="" class="auto-style75" src="Images/NP%20Tution%20Centre%20Logo.JPG" /></p>
    <table cellpadding="0" cellspacing="0" class="auto-style4">
        <tr>
            <td class="auto-style71" colspan="2"><strong><span class="auto-style72">View Info</span></strong></td>
        </tr>
        <tr>
                <td class="auto-style76">Tutor ID </td>
                <td class="auto-style68">
                    <asp:Label ID="lblTutorID" runat="server"></asp:Label>
                </td>
                </tr>
        <tr>
            <td class="auto-style76">Name</td>
            <td>
                <asp:Label ID="lblName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style76">Salutation</td>
            <td>
                <asp:Label ID="lblSalutation" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style76">Tel No</td>
            <td>
                <asp:Label ID="lblContactNo" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style76">Email Address</td>
            <td>
                <asp:Label ID="lblEmailAddr" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style76">Password</td>
            <td class="auto-style74">
                <asp:Label ID="lblPass" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style76">Free Day Of Week</td>
            <td class="auto-style74">
                <asp:Label ID="lblFreeDay" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style76">Free Time Slot</td>
            <td>
                <asp:Label ID="lblTimeSlot" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style76">Years of Experience</td>
            <td>
                <asp:Label ID="lblExperience" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style76">&nbsp;</td>
            <td>
                <asp:Button ID="btnedit" runat="server" Text="Edit" OnClick="btnedit_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style76">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
