<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="f6689_age.aspx.cs" Inherits="f6689_age" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:Label ID="mahLabel" runat="server">Today</asp:Label>
    <br />
    <asp:Label ID="myLabel" runat="server">Testi</asp:Label>
    <br />
    <asp:Button ID="lastYear" runat="server" OnClick="lastYear_Click" Text="<< Vuosi"/>
    <asp:Button ID="nextYear" runat="server" OnClick="nextYear_Click" Text="Vuosi >>"/>
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    
</asp:Content>

