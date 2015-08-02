<%@ Page Title="" Language="C#" MasterPageFile="~/Tutor.Master" AutoEventWireup="true" CodeBehind="updatetutorinfo.aspx.cs" Inherits="dwa_chk1.updatetutorinfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 823px;
            height: 213px;
        }
        .auto-style7 {
            width: 183px;
            height: 19px;
        }
        .auto-style13 {
            width: 628px;
            height: 19px;
        }
        .auto-style14 {
            margin-left: 0px;
        }
        .auto-style15 {
            width: 823px;
            height: 52px;
            font-size: x-large;
        }
        .auto-style16 {
            width: 823px;
            height: 214px;
        }
        .auto-style17 {
            width: 183px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style11">
        <img alt="" class="auto-style16" src="Images/NP%20Tution%20Centre%20Logo.JPG" /></p>
    <p>
        <table cellpadding="0" cellspacing="0" class="auto-style6">
            <tr>
                <td class="auto-style15" colspan="2"><strong>Update Tutor Information</strong></td>
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
                    <asp:TextBox ID="txtTelNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Email Address</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtNewEmailAddr" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">Old Password</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtOldPass" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvOldPass" runat="server" ErrorMessage="Please fill in your old password" ForeColor="Red" ControlToValidate="txtOldPass" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">New Password</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtNewPass" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNewPass" runat="server" ErrorMessage="Please fill in your new password" ForeColor="Red" ControlToValidate="txtNewPass" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Confirm New Password</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtCfmPass" runat="server" CssClass="auto-style14"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCfmNewPass" runat="server" ErrorMessage="Please fill in your confirm password" ForeColor="Red" Display="Dynamic" ControlToValidate="txtCfmPass"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="covPass" runat="server" ControlToCompare="txtNewPass" ControlToValidate="txtCfmPass" Display="Dynamic" ErrorMessage="The password you key in for new and confirm is different." ForeColor="Red" Operator="DataTypeCheck"></asp:CompareValidator>
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">Free Day Of Week&nbsp;&nbsp;</td>
                <td class="auto-style10">
                    <asp:DropDownList ID="ddlFreeDay" runat="server" Height="16px" OnSelectedIndexChanged="ddlFreeDay_SelectedIndexChanged" Width="131px" CssClass="auto-style14">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Free Time Slot</td>
                <td class="auto-style13">
                    <asp:DropDownList ID="ddlTimeSlot" runat="server" Height="25px" Width="290px" OnSelectedIndexChanged="ddlTimeSlot_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style13">
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                    <asp:Label ID="lblMessage2" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
