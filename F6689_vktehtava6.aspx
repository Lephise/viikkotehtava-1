<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="F6689_vktehtava6.aspx.cs" Inherits="F6689_vktehtava6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>SMLIIGA</h1>
    <asp:Button ID="btn1" runat="server" Text="Listaa pelaajat" OnClick="btn1_Click" /><br />
    <asp:Button ID="btn2" runat="server" Text="Listaa valittu joukkue" OnClick="btn2_Click" />
    <asp:DropDownList ID="drop" runat="server"></asp:DropDownList> 
    Valitse järjestely peruste: <asp:RadioButton ID="radio1" runat="server" Text="Aakkos" Checked="true" OnCheckedChanged="radio1_CheckedChanged " AutoPostback="true" />
    <asp:RadioButton ID="radio2" runat="server" Text="Teho" OnCheckedChanged="radio2_CheckedChanged" AutoPostback="true" /><br />
    <asp:Button ID="btn3" runat="server" Text="Listaa valittu pelipaikka" OnClick="btn3_Click"/>
    
    <asp:DropDownList ID="drop2" runat="server">
        <asp:ListItem Text="Hyökkääjä" Value ="H"></asp:ListItem>
        <asp:ListItem Text="Puolustaja" Value="P"></asp:ListItem>
        <asp:ListItem Text="Maalivahti" Value="M"></asp:ListItem>
    </asp:DropDownList> 
     Valitse järjestely peruste: <asp:RadioButton ID="radio3" runat="server" Text="Aakkos" Checked="true" AutoPostback="true" OnCheckedChanged="radio3_CheckedChanged" />
    <asp:RadioButton ID="radio4" runat="server" Text="Teho"  AutoPostback="true" OnCheckedChanged="radio4_CheckedChanged1" /><br />
    <asp:GridView ID="grid" runat="server"></asp:GridView> <br />
   
    
</asp:Content>

