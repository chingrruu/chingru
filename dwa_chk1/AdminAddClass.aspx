<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminAddClass.aspx.cs" Inherits="dwa_chk1.AdminAddClass" %>
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
                <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="revSubject" runat="server" ControlToValidate="txtSubject" Display="Dynamic" ErrorMessage="Please specify a subject" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Term</td>
            <td>
                <asp:DropDownList ID="ddlTerm" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Start Date</td>
            <td>
                <asp:TextBox ID="txtStartDate" runat="server" OnTextChanged="txtStartDate_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="revStartDate" runat="server" ControlToValidate="txtStartDate" Display="Dynamic" ErrorMessage="Please specify a date" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:Calendar ID="calStartDate" runat="server"></asp:Calendar>
                <asp:Label ID="lblStartDateMessage" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Day Of Week</td>
            <td>
                <asp:DropDownList ID="ddlDayOfWeek" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Time Slot</td>
            <td class="auto-style8">
                <asp:DropDownList ID="ddlTimeSlot" runat="server">
                </asp:DropDownList>
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
                <asp:DropDownList ID="ddlClassroom" runat="server" Height="16px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>
                <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" Width="64px" />
                <asp:Label ID="lblError" runat="server"></asp:Label>
                <asp:ValidationSummary ID="vsValidationSummary" runat="server" ForeColor="Red" />
            </td>
        </tr>
    </table>
</asp:Content>
