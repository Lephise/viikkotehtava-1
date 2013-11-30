<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Tehtava9vastausform.aspx.cs" Inherits="Tehtava9vastausform" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Kymysys</h1>
    <asp:Label ID="label" runat="server"></asp:Label>
   

    <asp:RadioButtonList ID="buttoset" runat="server"></asp:RadioButtonList>
    <asp:Button ID="btn" runat="server" OnClick="btn_Click" Text="Vastaa"/> <br />
    <asp:Label ID="vastmaara" runat="server"></asp:Label>
    
</asp:Content>

