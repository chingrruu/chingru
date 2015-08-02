<%@ Page Title="" Language="C#" MasterPageFile="~/Parent.Master" AutoEventWireup="true" CodeBehind="ViewRegisteredClass.aspx.cs" Inherits="dwa_chk1.ViewRegisteredClass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvRegisteredClass" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvRegisteredClass_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Subject" HeaderText="subject" />
            <asp:BoundField DataField="StartDate" HeaderText="start date" />
            <asp:BoundField DataField="DayOfWeek" HeaderText="day of week" />
            <asp:BoundField DataField="TimeSlot" HeaderText="time session" />
            <asp:BoundField DataField="TName" HeaderText="tutor" />
            <asp:BoundField DataField="Classroom" HeaderText="classroom" />
        </Columns>
    </asp:GridView>
</asp:Content>
