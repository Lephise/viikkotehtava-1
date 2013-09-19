<%@ Page Title="Viikkotehtävä 1" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="f6689_valuuttamuunnin.aspx.cs" Inherits="f6689_valuuttamuunnin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    Terve: <asp:TextBox ID="txtUser" runat="server"></asp:TextBox><br />
    Muunnan bitcoinit euroiksi, anna bitcoinien määrä: <asp:TextBox ID="txtCoin" runat="server"></asp:TextBox> 
    <asp:Button ID="btnConvert" runat="server" Text="Muunna" OnClick="btnConvert_Click" />
     <br />
    <asp:Label ID="lblCurr" runat="server" Text="..."></asp:Label> <br />
    <asp:ListBox ID="lstOne" runat="server"></asp:ListBox>
    <asp:ListBox ID="ListTwo" runat="server"></asp:ListBox>
</asp:Content>

