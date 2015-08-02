<%@ Page Title="" Language="C#" MasterPageFile="~/Tutor.Master" AutoEventWireup="true" CodeBehind="viewclassestaken.aspx.cs" Inherits="dwa_chk1.viewclassestaken" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 823px;
            height: 213px;
        }
        .auto-style101 {
        margin-bottom: 0px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <img alt="" class="auto-style4" src="Images/NP%20Tution%20Centre%20Logo.JPG" /></p>
    <p>
        Tuition Class ID:
        <asp:DropDownList ID="ddlTC" runat="server" OnSelectedIndexChanged="ddlTC_SelectedIndexChanged" AutoPostBack="True" CssClass="auto-style101">
        </asp:DropDownList>
    </p>
    <asp:GridView ID="gvCT" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvCT_SelectedIndexChanged" AllowPaging="True" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" PageSize="5" CssClass="auto-style101">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:BoundField DataField="TuitionClassID" HeaderText="Tuition Class ID" />
            <asp:BoundField DataField="Subject" HeaderText="Subject" />
            <asp:BoundField DataField="Term" HeaderText="Term" />
            <asp:BoundField DataField="StartDate" HeaderText="Start Date" />
            <asp:BoundField DataField="DayOfWeek" HeaderText="Day of Week" />
            <asp:BoundField DataField="TimeSlot" HeaderText="Time Slot" />
            <asp:BoundField DataField="NumSession" HeaderText="Num Session" />
            <asp:BoundField DataField="Classroom" HeaderText="Classroom" />
            <asp:HyperLinkField DataNavigateUrlFields="TuitionClassID" DataNavigateUrlFormatString="viewclasstakenbytutor.aspx?classStudentID={0}" HeaderText="Select" Text="Select" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>
    </asp:Content>
