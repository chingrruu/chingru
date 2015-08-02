<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TutorMenu.ascx.cs" Inherits="dwa_chk1.TutorMenu" %>
<asp:Menu ID="menuHome" runat="server" Orientation="Horizontal">
    <Items>
        <asp:MenuItem NavigateUrl="~/viewinfo.aspx" Text="- View Info" Value="- View Info">
        </asp:MenuItem>
        <asp:MenuItem Text="- View Available Classes" Value="- View Available Classes" NavigateUrl="~/viewavailclass.aspx"></asp:MenuItem>
        <asp:MenuItem Text="- View Classes Taken" Value="- View Classes Taken" NavigateUrl="~/viewclassestaken.aspx">
            <asp:MenuItem NavigateUrl="~/viewclasstakenbytutor.aspx" Text="View Attendance" Value="View Attendance"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem Text="- View Student Progress Report" Value="- View Student Progress Repor"></asp:MenuItem>
        <asp:MenuItem Text="- Create Feedback" Value="- Create Feedback" NavigateUrl="~/T_create_feedback.aspx"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/T_discussion_response.aspx" Text="- Discussion Topic" Value="- Discussion Topic"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/deregisterclass.aspx" Text="- Deregister" Value="- Deregister"></asp:MenuItem>
    </Items>
</asp:Menu>
