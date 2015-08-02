<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminConfirmAddClass.aspx.cs" Inherits="dwa_chk1.AdminConfirmAddClass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style4 {
            width: 100%;
        }
        .auto-style6 {
            width: 205px;
            font-size: x-large;
        }
        .auto-style5 {
            width: 205px;
        }
        .auto-style7 {
            width: 205px;
            height: 22px;
        }
        .auto-style8 {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" cellspacing="0" class="auto-style4">
        <tr>
            <td class="auto-style6"><strong>Add Tuition Class</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">Tuition Class ID</td>
            <td>
                <asp:Label ID="lblClassID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Subject</td>
            <td>
                <asp:Label ID="lblSubject" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Term</td>
            <td>
                <asp:Label ID="lblTerm" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Start Date</td>
            <td>
                <asp:Label ID="lblStartDate" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Day Of Week</td>
            <td>
                <asp:Label ID="lblDayOfWeek" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Time Slot</td>
            <td class="auto-style8">
                <asp:Label ID="lblTimeSlot" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Number Of Sessions</td>
            <td>
                <asp:Label ID="lblNumberOfSessions" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Classroom</td>
            <td>
                <asp:Label ID="lblClassroom" runat="server"></asp:Label>
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
