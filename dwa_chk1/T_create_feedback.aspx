<%@ Page Title="" Language="C#" MasterPageFile="~/Tutor.Master" AutoEventWireup="true" CodeBehind="T_create_feedback.aspx.cs" Inherits="dwa_chk1.T_create_feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style11 {
            text-align: left;
            height: 208px;
        }
        .auto-style3 {
            width: 823px;
            height: 213px;
        }
        .auto-style6 {
        width: 50%;
        height: 135px;
    }
        .auto-style15 {
            width: 823px;
            font-size: x-large;
            text-align: left;
            height: 14px;
        }
        .auto-style7 {
            width: 200px;
        }
        .auto-style17 {
            width: 200px;
            height: 55px;
        }
        .auto-style18 {
            width: 331%;
        }
        .auto-style19 {
            width: 823px;
            height: 206px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style11">
        <img alt="" class="auto-style19" src="Images/NP%20Tution%20Centre%20Logo.JPG" /></p>
    <p>
        <table cellpadding="0" cellspacing="0" class="auto-style6">
            <tr>
                <td class="auto-style15"><strong>Create Feedback</strong></td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <table class="auto-style18">
                        <tr>
                            <td>Student ID:
                                <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Tuiton Class ID:
                                <asp:TextBox ID="txtTClassID" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td><em>Please enter your feedback</em></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtFeedback" runat="server" Height="45px" Width="818px" OnTextChanged="txtFeed_TextChanged"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:RequiredFieldValidator ID="rfvFeedback" runat="server" ControlToValidate="txtFeedback" Display="Dynamic" ErrorMessage="Feedback field cannot be blank" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
