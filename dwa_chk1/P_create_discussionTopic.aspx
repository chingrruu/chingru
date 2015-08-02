<%@ Page Title="" Language="C#" MasterPageFile="~/Parent.Master" AutoEventWireup="true" CodeFile="P_create_discussionTopic.aspx.cs" Inherits="dwa_chk1.P_create_discussionTopic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style13 {
            text-align: left;
        }
        .auto-style14 {
            width: 823px;
            height: 213px;
        }
        .auto-style12 {
            width: 49%;
            height: 142px;
            margin-left: 0px;
        }
        .auto-style21 {
            width: 260px;
            height: 19px;
        }
        .auto-style15 {
            width: 260px;
        }
        .auto-style26 {
            font-size: x-large;
        }
        .auto-style30 {
            width: 100px;
            height: 19px;
        }
        .auto-style31 {
            width: 100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style13">
        <img alt="" class="auto-style14" src="Images/NP%20Tution%20Centre%20Logo.JPG" /></p>
    <table align="center" cellpadding="0" cellspacing="0" class="auto-style12">
        <tr>
            <td class="auto-style13" colspan="2"><strong><span class="auto-style26">Create Discussion Topic</span></strong></td>
        </tr>
        <tr>
            <td class="auto-style30">Student ID:</td>
            <td class="auto-style21">
                <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style31">Name of Teacher</td>
            <td class="auto-style15">
                <asp:DropDownList ID="ddlTName" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style31">Class ID</td>
            <td>
                <asp:DropDownList ID="ddlTClass" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style31">Discussion Title</td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style31">Discussion Text</td>
            <td>
                <asp:TextBox ID="txtText" runat="server" Height="118px" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style31">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="123px" OnClick="btnSubmit_Click" />
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
