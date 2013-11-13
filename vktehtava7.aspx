<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="vktehtava7.aspx.cs" Inherits="vktehtava7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>JINTA-ROUPPI</h1>
    <asp:Button ID="btn1" Text="Hae autot" runat="server" OnClick="btn1_Click"/>
    <asp:GridView ID="grid" runat="server" OnRowEditing="GridView1_RowEditing" AutoGenerateEditButton="true" OnRowUpdating="GridView1_RowUpdating" AutoGenerateColumns="true" Height="146px" Width="456px"></asp:GridView>
</asp:Content>

