<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ParentMenu.ascx.cs" Inherits="dwa_chk1.Menu" %>
<asp:Menu ID="menuHome" runat="server" Orientation="Horizontal">
    <Items>
        <asp:MenuItem NavigateUrl="~/ViewAvailableClass2.aspx" Text="- Available Classes" Value="- Available Classes"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/ViewRegisteredClass.aspx" Text="- Registered Class Details" Value="- Registered Class Details"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/P_view_Feedback.aspx" Text="- View Child Feedback" Value="- View Child Feedback"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/P_create_discussionTopic.aspx" Text="- Create Discussion Topic" Value="- Create Discussion Topic"></asp:MenuItem>
        <asp:MenuItem Text="- Make Appointment" Value="- Make Appointment"></asp:MenuItem>
    </Items>
</asp:Menu>


