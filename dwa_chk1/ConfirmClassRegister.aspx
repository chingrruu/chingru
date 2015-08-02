<%@ Page Title="" Language="C#" MasterPageFile="~/Parent.Master" AutoEventWireup="true" CodeBehind="ConfirmClassRegister.aspx.cs" Inherits="dwa_chk1.ConfirmClassRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style4 {
            width: 100%;
        }
        .auto-style6 {
            font-size: x-large;
        }
        .auto-style5 {
            width: 200px;
        }
        .auto-style7 {
            width: 200px;
            height: 23px;
        }
        .auto-style8 {
            height: 23px;
        }
        .auto-style9 {
            width: 200px;
            height: 48px;
        }
        .auto-style10 {
            height: 48px;
        }
        .auto-style11 {
            width: 200px;
            height: 30px;
        }
        .auto-style12 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4">
        <tr>
            <td class="auto-style6" colspan="2"><strong>Confirm Class Registration</strong></td>
        </tr>
        <tr>
            <td class="auto-style7">Tuition Class ID</td>
            <td class="auto-style8">
                <asp:Label ID="lblClassid" runat="server"></asp:Label>
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
            <td class="auto-style7">Start Date</td>
            <td class="auto-style8">
                <asp:Label ID="lblStartdate" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Day Of Week</td>
            <td>
                <asp:Label ID="lblDayofweek" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Time Slot</td>
            <td>
                <asp:Label ID="lblTimeslot" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Number Of Sessions</td>
            <td class="auto-style8">
                <asp:Label ID="lblSession" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Classroom</td>
            <td>
                <asp:Label ID="lblClassroom" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">Student Name</td>
            <td class="auto-style12">
                <asp:TextBox ID="txtSname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvSname" runat="server" ControlToValidate="txtSname" Display="Dynamic" ErrorMessage="Please enter student name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
            </td>
            <td class="auto-style10">
                <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />
                <br />
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblMessage3" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
