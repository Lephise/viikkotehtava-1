<%@ Page Title="RegexiStuffaa" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MyRegEx.aspx.cs" Inherits="MyRegEx" theme="Kaunis"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Regular Expression testi</h1>
    <h2>Kirjoita oheiseen text boksiin jotakin</h2>
    <br />Name plox: <br />
    <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
    <asp:Button ID="btn1" runat="server" Text="Validate" OnClick="btn1_Click" style="height: 26px" /> <br />
    <asp:Label ID="lbl1" runat="server"></asp:Label>

    <br />Anna eemaili: <br />
    <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
    <asp:Button ID="btn2" runat="server" Text="Validate" style="height: 26px" OnClick="btn2_Click" /> <br />
    <asp:Label ID="lbl2" runat="server"></asp:Label>
</asp:Content>

