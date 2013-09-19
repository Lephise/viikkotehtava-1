<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="f6689_indexMP.aspx.cs" Inherits="f6689_indexMP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="font-size: large">
    
        <h1>Viikon 37 tuntiharjoitukset</h1>
        <asp:HyperLink ID="HyperLink3" runat="server">Viinit</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server">Age Counter</asp:HyperLink>
        <br />
        <h2>Viikon 38 tuntiharjoitukset</h2>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/f6689_age.aspx">Age Counter</asp:HyperLink>

        <h1>Viikkotehtävät 1 ja 2</h1>
        <asp:TextBox ID="textName" runat="server" Text="Tähän nimesi"></asp:TextBox>
        <asp:Button ID="button1" runat="server" Text="Välitä parametrin"/>
        <asp:Button ID="button2" runat="server" Text="Tallenna sessioniin"/>
        <asp:Button ID="button3" runat="server" Text="Tallenna cookieihin"/>
    </div>

</asp:Content>



