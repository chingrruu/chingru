<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminMenu.ascx.cs" Inherits="dwa_chk1.AdminMenu" %>
<asp:Menu ID="menuHome" runat="server" Orientation="Horizontal">
    <Items>
        <asp:MenuItem NavigateUrl="Main.aspx" Text="- View Tutors" Value="- View Tutors"></asp:MenuItem>
        <asp:MenuItem Text="- View Classes" Value="- View Classes"></asp:MenuItem>
    </Items>
</asp:Menu>
