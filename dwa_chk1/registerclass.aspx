<%@ Page Title="" Language="C#" MasterPageFile="~/Tutor.Master" AutoEventWireup="true" CodeBehind="registerclass.aspx.cs" Inherits="dwa_chk1.registerclass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style14 {
            width: 823px;
            height: 213px;
        }
        .auto-style12 {
            width: 49%;
            height: 142px;
            margin-left: 0px;
        }
        .auto-style17 {
            width: 145px;
        }
        .auto-style15 {
            width: 260px;
        }
        .auto-style20 {
            width: 145px;
            height: 19px;
        }
        .auto-style21 {
            width: 260px;
            height: 19px;
        }
        .auto-style22 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style13">
        <img alt="" class="auto-style14" src="Images/NP%20Tution%20Centre%20Logo.JPG" /></p>
    <table cellpadding="0" cellspacing="0" class="auto-style12" align="center">
        <tr>
            <td colspan="2"><strong><span class="auto-style22">Register Class</span></strong></td>
        </tr>
        <tr>
            <td class="auto-style17">Tuition Class ID</td>
            <td class="auto-style15">
                <asp:Label ID="lblClassID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">Subject</td>
            <td class="auto-style15">
                <asp:Label ID="lblSubject" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">Term</td>
            <td class="auto-style15">
                <asp:Label ID="lblTerm" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">Start Date</td>
            <td class="auto-style15">
                <asp:Label ID="lblStartDate" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style20">Day of Week</td>
            <td class="auto-style21">
                <asp:Label ID="lblDayOfWeek" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style20">Time Slot</td>
            <td class="auto-style21">
                <asp:Label ID="lblTimeSlot" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">Number of Sessions</td>
            <td class="auto-style15">
                <asp:Label ID="lblNumSession" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">Classroom</td>
            <td class="auto-style15">
                <asp:Label ID="lblClassroom" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">Tutor ID</td>
            <td class="auto-style15">
                <asp:Label ID="lblTutorID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
