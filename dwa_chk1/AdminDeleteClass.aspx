<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDeleteClass.aspx.cs" Inherits="dwa_chk1.AdminDeleteClass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-align: left">
        Are you sure you want to delete Tuition Class ID
        <asp:Label ID="lblClassID" runat="server"></asp:Label>
        ?</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click1" Text="No" />
    </p>
    <p>
&nbsp;<asp:Label ID="lblMessage" runat="server"></asp:Label>
    </p>
    <p>
        <asp:HyperLink ID="lnkViewClass" runat="server" NavigateUrl="~/AdminViewClass.aspx">Back to view class</asp:HyperLink>
    </p>
</asp:Content>
