<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Tehtava9.aspx.cs" Inherits="Tehtava9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Lisää kysymys</h1>
    Kysymys: <asp:TextBox TextMode="MultiLine" width="300" Height="100" ID="kysymys" runat="server"></asp:TextBox>
    <br />

    Vastausten määrä: <asp:DropDownList id="maara" runat="server" OnSelectedIndexChanged="maara_SelectedIndexChanged" AutoPostBack="True" >
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
       
    </asp:DropDownList>

    <asp:TextBox ID="vaiht1" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="vaiht2" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="vaiht3" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="vaiht4" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="vaiht5" runat="server" Visible="false"></asp:TextBox>
    
    <asp:Button ID="submit" runat="server" OnClick="submit_Click" />
</asp:Content>

