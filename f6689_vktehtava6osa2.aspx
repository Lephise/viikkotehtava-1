<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="f6689_vktehtava6osa2.aspx.cs" Inherits="f6689_vktehtava6osa2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Lisää Pelaaja</h1>
    Etunimi: <asp:TextBox ID="txt1" runat="server"  ></asp:TextBox>
    Sukunimi: <asp:TextBox ID="txt2" runat="server"  ></asp:TextBox>
    <asp:DropDownList ID="drop" runat="server"></asp:DropDownList> 
    <asp:DropDownList ID="drop2" runat="server">
        <asp:ListItem Text="Hyökkääjä" Value ="H"></asp:ListItem>
        <asp:ListItem Text="Puolustaja" Value="P"></asp:ListItem>
        <asp:ListItem Text="Maalivahti" Value="M"></asp:ListItem>
    </asp:DropDownList> 
    <asp:Button ID="btn" Text="Lisää" runat="server" OnClick="btn_Click" />
</asp:Content>

