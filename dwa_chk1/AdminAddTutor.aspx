<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminAddTutor.aspx.cs" Inherits="dwa_chk1.AdminAddTutor" %>
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
            height: 20px;
        }
        .auto-style8 {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" cellspacing="0" class="auto-style4">
        <tr>
            <td class="auto-style6"><strong>Add Tutor</strong></td>
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
                <asp:DropDownList ID="ddlSalutation" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" Display="Dynamic" ErrorMessage="Please specify a name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Contact Number</td>
            <td>
                <asp:TextBox ID="txtContactNumber" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvContactNumber" runat="server" ControlToValidate="txtContactNumber" Display="Dynamic" ErrorMessage="Please specify a contact number" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revContactNumber" runat="server" ControlToValidate="txtContactNumber" Display="Dynamic" ErrorMessage="Please specify a correct format mobile number" ForeColor="Red" ValidationExpression="^\d{8}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Email Address</td>
            <td>
                <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEmailAddress" runat="server" ControlToValidate="txtEmailAddress" Display="Dynamic" ErrorMessage="Please specify a email address" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmailAddress" runat="server" ControlToValidate="txtEmailAddress" Display="Dynamic" ErrorMessage="Please specify a correct format email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Password</td>
            <td class="auto-style8">
                <asp:Label ID="lblPassword" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Years Of Experience</td>
            <td>
                <asp:TextBox ID="txtYearsOfExperience" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvYearsOfExperience" runat="server" ControlToValidate="txtYearsOfExperience" Display="Dynamic" ErrorMessage="Please specify years of experience" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="covYearsOfExperience" runat="server" ControlToValidate="txtYearsOfExperience" Display="Dynamic" ErrorMessage="Please specify a valid years of experience" ForeColor="Red" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                <asp:RangeValidator ID="ravYearsOfExperience" runat="server" ControlToValidate="txtYearsOfExperience" Display="Dynamic" ErrorMessage="Please specify 1 year and above" ForeColor="Red" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>
                <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" />
                <asp:ValidationSummary ID="vsValidationSummary" runat="server" ForeColor="Red" />
            </td>
        </tr>
    </table>
</asp:Content>
