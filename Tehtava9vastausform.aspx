<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Tehtava9vastausform.aspx.cs" Inherits="Tehtava9vastausform" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="label" runat="server"></asp:Label>
    <asp:Panel id="vaihtoehdot" runat="server" />
    <asp:Button ID="btn" runat="server" OnClick="btn_Click" />
    
</asp:Content>

