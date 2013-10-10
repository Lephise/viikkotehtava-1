<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="f6689_finnkino.aspx.cs" Inherits="f6689_finnkino" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ListBox ID="myListBox" runat="server" DataTextField="ID" 
        rows="18" OnSelectedIndexChanged="myListBox_SelectedIndexChanged"
        AutoPostBack="true" /><br />
    <asp:Button ID="btnGetTheatres" runat="server" Text="Hae elokuvateatterit" OnClick="btnGetTheatres_Click"/>
    
    <asp:XmlDataSource ID="myDataSource" runat="server" XPath="Schedule/Shows/Show"/><br />

    <asp:Repeater ID="myRepeater" runat="server">
        <ItemTemplate>
        <!-- esitetään elokuvan kuva -->
            <asp:Image ID="image1" runat="server"
                ImageUrl='<%#XPath("Images/EventSmallImagePortrait") %>' />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

