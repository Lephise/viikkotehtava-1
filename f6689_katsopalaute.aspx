<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="f6689_katsopalaute.aspx.cs" Inherits="f6689_katsopalaute" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Palautteet</h1>
    <asp:Button ID="btnPalautteet" runat="server" Text="Näytä palautteet" OnClick="btnPalautteet_Click" />
   

   <asp:GridView ID="grid" runat="server"></asp:GridView>

    

</asp:Content>


