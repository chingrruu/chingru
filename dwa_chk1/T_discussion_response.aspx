﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Tutor.Master" AutoEventWireup="true" CodeBehind="T_discussion_response.aspx.cs" Inherits="dwa_chk1.T_discussion_response" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .auto-style11 {
            text-align: left;
        }
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
        .auto-style30 {
            width: 100px;
            height: 19px;
        }
        .auto-style21 {
            width: 260px;
            height: 19px;
            margin-left: 40px;
        }
        .auto-style31 {
            width: 100px;
        }
        .auto-style15 {
            width: 260px;
        }
        .auto-style32 {
            text-align: left;
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style13">
        <img alt="" class="auto-style14" src="Images/NP%20Tution%20Centre%20Logo.JPG" /></p>
    <table align="center" cellpadding="0" cellspacing="0" class="auto-style12">
        <tr>
            <td class="auto-style32" colspan="2"><strong>Create Response</strong></td>
        </tr>
        <tr>
            <td colspan="2"><em>Please enter your response below:</em></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="txtResponse" runat="server" Height="66px" Width="553px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style31">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="100px" OnClick="btnSubmit_Click" />
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <p class="auto-style11">
        &nbsp;</p>
</asp:Content>
