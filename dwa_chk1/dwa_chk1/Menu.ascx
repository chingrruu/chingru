<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="dwa_chk1.Menu" %>
<asp:Menu ID="menuHome" runat="server" Orientation="Horizontal">
    <Items>
        <asp:MenuItem NavigateUrl="Main.aspx" Text="Home" Value="Home"></asp:MenuItem>
        <asp:MenuItem Text="About Us" Value="About Us"></asp:MenuItem>
        <asp:MenuItem Text="Tutors" Value="Tutors"></asp:MenuItem>
        <asp:MenuItem Text="Parent Register" Value="Parent Register"></asp:MenuItem>
    </Items>
</asp:Menu>

