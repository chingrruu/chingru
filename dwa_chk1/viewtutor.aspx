<%@ Page Title="" Language="C#" MasterPageFile="~/Tutor.Master" AutoEventWireup="true" CodeBehind="viewtutor.aspx.cs" Inherits="dwa_chk1.viewtutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 823px;
        }
        .auto-style3 {
            width: 823px;
            height: 213px;
        }
        .auto-style63 {
            text-align: left;
        }
        .auto-style64 {
            width: 823px;
            height: 213px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style63">
        <img alt="" class="auto-style64" src="Images/NP%20Tution%20Centre%20Logo.JPG" /></p>
    <p class="auto-style63">
        <asp:GridView ID="gvTutor" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvTutor_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="TutorID" HeaderText="Tutor ID" />
                <asp:BoundField DataField="TName" HeaderText="Name" />
                <asp:BoundField DataField="TSalutation" HeaderText="Salutation" />
                <asp:BoundField DataField="TTelNo" HeaderText="Tel No" />
                <asp:BoundField DataField="TEmailAddr" HeaderText="Email Address" />
                <asp:BoundField DataField="TPassword" HeaderText="Password" />
                <asp:BoundField DataField="FreeDayOfWeek" HeaderText="Free Day Of Week" />
                <asp:BoundField DataField="FreeTimeSlot" HeaderText="Free Time Slot" />
                <asp:BoundField DataField="TExperience" HeaderText="Experience" />
                <asp:HyperLinkField DataNavigateUrlFields="TutorID" DataNavigateUrlFormatString="updatetutorinfo.aspx?tutorid={0}" HeaderText="Edit" Text="Update" />
            </Columns>
        </asp:GridView>
    </p>
    <p class="auto-style63">
        &nbsp;</p>
</asp:Content>
