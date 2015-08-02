<%@ Page Title="" Language="C#" MasterPageFile="~/Tutor.Master" AutoEventWireup="true" CodeBehind="confirmupdatetutorinfo.aspx.cs" Inherits="dwa_chk1.confirmupdatetutorinfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 823px;
        }
        .auto-style31 {
            text-align: left;
        }
        .auto-style32 {
            width: 823px;
            height: 213px;
        }
        .auto-style33 {
            width: 100%;
        }
        .auto-style34 {
            font-size: x-large;
        }
        .auto-style35 {
            width: 200px;
        }
        .auto-style7 {
            width: 1107px;
        }
        .auto-style13 {
            width: 628px;
        }
        .auto-style9 {
        width: 1107px;
        height: 27px;
            }
    .auto-style10 {
        height: 27px;
            width: 628px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style31">
        <img alt="" class="auto-style32" src="Images/NP%20Tution%20Centre%20Logo.JPG" /></p>
    <table cellpadding="0" cellspacing="0" class="auto-style33">
        <tr>
            <td class="auto-style34" colspan="2"><strong>Confirm Update Tutor Information</strong></td>
        </tr>
        <tr>
                <td class="auto-style7">Tutor ID</td>
                <td class="auto-style13">
                    <asp:Label ID="lblTutorID" runat="server"></asp:Label>
            </td>
            </tr>
        <tr>
                <td class="auto-style7">Name</td>
                <td class="auto-style13">
                    <asp:Label ID="lblName" runat="server"></asp:Label>
            </td>
            </tr>
        <tr>
                <td class="auto-style7">Salutation</td>
                <td class="auto-style13">
                    <asp:Label ID="lblSalutation" runat="server"></asp:Label>
            </td>
            </tr>
        <tr>
                <td class="auto-style7">Telephone Number</td>
                <td class="auto-style13">
                    <asp:Label ID="lblTelNo" runat="server"></asp:Label>
            </td>
            </tr>
        <tr>
                <td class="auto-style7">New Email Address</td>
                <td class="auto-style13">
                    <asp:Label ID="lblNewEmailAddr" runat="server"></asp:Label>
                </td>
            </tr>
        <tr>
                <td class="auto-style9">Confirm New Email Address</td>
                <td class="auto-style10">
                    <asp:Label ID="lblCfmNewEmailAddr" runat="server"></asp:Label>
                </td>
            </tr>
        <tr>
                <td class="auto-style7">New Password</td>
                <td class="auto-style13">
                    <asp:Label ID="lblNewPass" runat="server"></asp:Label>
                </td>
            </tr>
        <tr>
                <td class="auto-style7">Confirm New Password</td>
                <td class="auto-style13">
                    <asp:Label ID="lblCfmPass" runat="server"></asp:Label>
                </td>
            </tr>
        <tr>
                <td class="auto-style9">Free Day Of Week&nbsp;&nbsp;</td>
                <td class="auto-style10">
                    <asp:Label ID="lblFreeDay" runat="server"></asp:Label>
                </td>
            </tr>
        <tr>
                <td class="auto-style7">Free Time Slot</td>
                <td class="auto-style13">
                    <asp:Label ID="lblTimeSlot" runat="server"></asp:Label>
                </td>
            </tr>
        <tr>
            <td class="auto-style35">
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style35">
                &nbsp;</td>
            <td>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
