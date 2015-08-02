<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminConfirmAddTutor.aspx.cs" Inherits="dwa_chk1.AdminConfirmAddTutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }
            .auto-style5 {
                width: 205px;
            }
            .auto-style6 {
                width: 205px;
                height: 19px;
            }
            .auto-style7 {
                height: 19px;
            }
            .auto-style8 {
                width: 205px;
                font-size: x-large;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" cellspacing="0" class="auto-style4">
        <tr>
            <td class="auto-style8"><strong>Add Tutor</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">Tutor ID</td>
            <td>
                <asp:Label ID="lblTutorID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Salutation</td>
            <td>
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
                <asp:Label ID="lblContactNumber" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Email Address</td>
            <td>
                <asp:Label ID="lblEmailAddress" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Password</td>
            <td class="auto-style7">
                <asp:Label ID="lblPassword" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Years Of Experience</td>
            <td>
                <asp:Label ID="lblYearsOfExperience" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
            </td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                <asp:Label ID="lblText" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
