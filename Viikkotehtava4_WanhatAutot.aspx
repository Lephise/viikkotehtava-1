<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Viikkotehtava4_WanhatAutot.aspx.cs" Inherits="Viikkotehtava4_WanhatAutot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Wanhat Autot</h1>
    
    <asp:GridView ID="grid" runat="server" AllowSorting="true"></asp:GridView>
    <asp:Button ID="button" runat="server" Text="Näytä kaikki autot" OnClick="button_Click"></asp:Button>
    <asp:RadioButton ID="asc" runat="server" Text="Nouseva" />
    <asp:RadioButton ID="desc" runat="server" Text="Laskeva" />
    <asp:ListBox ID="merkit" runat="server" OnSelectedIndexChanged="merkit_SelectedIndexChanged"></asp:ListBox>
    <asp:Label ID="label1" runat="server"></asp:Label>
    <asp:Label ID="label2" runat="server"></asp:Label>
    
</asp:Content>

