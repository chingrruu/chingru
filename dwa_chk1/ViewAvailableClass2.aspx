<%@ Page Title="" Language="C#" MasterPageFile="~/Parent.Master" AutoEventWireup="true" CodeBehind="ViewAvailableClass2.aspx.cs" Inherits="dwa_chk1.RegisterAvailableClass2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvAvailableClass" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-left: 0px" AutoGenerateColumns="False">
    <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="TuitionClassID" HeaderText="Tuition Class ID" />
            <asp:BoundField DataField="Subject" HeaderText="Subject" />
            <asp:BoundField DataField="Term" HeaderText="Term" />
            <asp:BoundField DataField="StartDate" HeaderText="StartDate" />
            <asp:BoundField DataField="DayOfWeek" HeaderText="DayOfWeek" />
            <asp:BoundField DataField="TimeSlot" HeaderText="TimeSlot" />
            <asp:BoundField DataField="NumSession" HeaderText="NumSession" />
            <asp:BoundField DataField="Classroom" HeaderText="Classroom" />
            <asp:BoundField DataField="TName" HeaderText="TutorName" />
            <asp:BoundField DataField="TSalutation" HeaderText="TutorSalutation" />
            <asp:HyperLinkField DataNavigateUrlFields="TuitionClassID" DataNavigateUrlFormatString="ConfirmClassRegister.aspx?TuitionClassID={0}" HeaderText="Registration" Text="Register" />
        </Columns>
    <FooterStyle BackColor="#CCCCCC" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="Gray" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>
</asp:Content>
