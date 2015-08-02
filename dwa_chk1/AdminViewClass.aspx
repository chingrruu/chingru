<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminViewClass.aspx.cs" Inherits="dwa_chk1.AdminViewClass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvClass" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" OnPageIndexChanging="gvClass_PageIndexChanging" PageSize="5">
        <Columns>
            <asp:BoundField DataField="TuitionClassID" HeaderText="Tuition Class ID" />
            <asp:BoundField DataField="Subject" HeaderText="Subject" />
            <asp:BoundField DataField="Term" HeaderText="Term" />
            <asp:BoundField DataField="StartDate" HeaderText="Start Date" />
            <asp:BoundField DataField="DayOfWeek" HeaderText="Day Of Week" />
            <asp:BoundField DataField="TimeSlot" HeaderText="Time Slot" />
            <asp:BoundField DataField="NumSession" HeaderText="Number Of Sessions" />
            <asp:BoundField DataField="Classroom" HeaderText="Classroom" />
            <asp:BoundField DataField="TutorID" HeaderText="Tutor ID" />
            <asp:TemplateField HeaderText="Class Capacity"></asp:TemplateField>
            <asp:HyperLinkField DataNavigateUrlFields="TuitionClassID" DataNavigateUrlFormatString="AdminDeleteClass.aspx?cid={0}" Text="Delete" />
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
    </asp:GridView>
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
</asp:Content>
