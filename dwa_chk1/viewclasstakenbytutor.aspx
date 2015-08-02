<%@ Page Title="" Language="C#" MasterPageFile="~/Tutor.Master" AutoEventWireup="true" CodeBehind="viewclasstakenbytutor.aspx.cs" Inherits="dwa_chk1.viewclasstakenbytutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 823px;
        }
        .auto-style3 {
            width: 823px;
            height: 213px;
        }
        .auto-style4 {
            font-size: x-large;
        }
        .auto-style45 {
            margin-top: 0px;
        }
        .auto-style46 {
            width: 823px;
            height: 213px;
        }
        .auto-style102 {
            font-size: medium;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <img alt="" class="auto-style46" src="Images/NP%20Tution%20Centre%20Logo.JPG" /></p>
    <p class="auto-style4">
        <strong>Attendance List</strong></p>
    <p class="auto-style4">
        <span class="auto-style102">Class Session Date:</span>
        <asp:DropDownList ID="ddlSD" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSD_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
        <asp:GridView ID="gvAttendance" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="auto-style45" Height="16px" Width="770px" OnRowCommand="gvAttendance_RowCommand" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="AttendanceID" HeaderText="Attendance ID" />
                <asp:BoundField DataField="ClassStudentID" HeaderText="Class Student ID" />
                <asp:BoundField DataField="StudentName" HeaderText="Name" />
                <asp:BoundField DataField="ClassSessionDate" HeaderText="Class Session Date" />
                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:DropDownList ID="ddlStatus" runat="server" SelectedValue='<%# Eval("Status") %>'>
                            <asp:ListItem>P</asp:ListItem>
                            <asp:ListItem>A</asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Remarks">
                    <ItemTemplate>
                        <asp:TextBox ID="txtRemarks" runat="server" Text='<%# Eval("Remarks") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="DateCreated" HeaderText="Date Created" />
                <asp:ButtonField ButtonType="Button" CommandName="UpdateRemarks" Text="Update" />
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
    <p>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </p>
    </asp:Content>
