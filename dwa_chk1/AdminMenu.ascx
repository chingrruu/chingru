<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminMenu.ascx.cs" Inherits="dwa_chk1.AdminMenu" %>
<asp:Menu ID="menuHome" runat="server" Orientation="Horizontal">
    <Items>
        <asp:MenuItem NavigateUrl="~/AdminAddClass.aspx" Text="- Add Class" Value="- View Tutors"></asp:MenuItem>
        <asp:MenuItem Text="- Add Tutor" Value="- View Classes" NavigateUrl="~/AdminAddTutor.aspx"></asp:MenuItem>
        <asp:MenuItem Text="- View Class" Value="- View Class" NavigateUrl="~/AdminViewClass.aspx"></asp:MenuItem>
        <asp:MenuItem Text="- Logout" Value="- Logout" NavigateUrl="~/Index.html"></asp:MenuItem>
    </Items>
</asp:Menu>
