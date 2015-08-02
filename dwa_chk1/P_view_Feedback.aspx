<%@ Page Title="" Language="C#" MasterPageFile="~/Parent.Master" AutoEventWireup="true" CodeBehind="P_view_Feedback.aspx.cs" Inherits="dwa_chk1.P_view_Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .auto-style11 {
            text-align: left;
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
            text-align: center;
            height: 14px;
        }
        .auto-style17 {
            width: 200px;
            height: 55px;
        }
        .auto-style18 {
            width: 331%;
        }
        .auto-style7 {
            width: 200px;
        }
        .auto-style19 {
            width: 823px;
            font-size: x-large;
            text-align: left;
            height: 14px;
        }
        .auto-style20 {
            font-size: medium;
        }
        .auto-style21 {
            font-size: large;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style11">
        <img alt="" class="auto-style3" src="Images/NP%20Tution%20Centre%20Logo.JPG" /></p>
    <p>
        <table cellpadding="0" cellspacing="0" class="auto-style6">
            <tr>
                <td class="auto-style15"><strong>View Feedback</strong></td>
            </tr>
            <tr>
                <td class="auto-style19">
                    <span class="auto-style21">Student ID:</span><span class="auto-style20"> </span>
                    <asp:DropDownList ID="ddlStudentID" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <table class="auto-style18">
                        <tr>
                            <td>
                                <asp:GridView ID="gvFeedback" runat="server" AutoGenerateColumns="False">
                                    <Columns>
                                        <asp:BoundField DataField="ClassStudentID" HeaderText="Student ID" />
                                        <asp:BoundField DataField="StudentName" HeaderText="Student Name" />
                                        <asp:BoundField DataField="TuitionClassID" HeaderText="Class ID" />
                                        <asp:BoundField DataField="Feedback" HeaderText="Feedback" />
                                    </Columns>
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                            </td>
                        </tr>
                        </table>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="btnSubmit" runat="server" Text="Create Discussion Topic" Width="230px" OnClick="btnSubmit_Click" />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
