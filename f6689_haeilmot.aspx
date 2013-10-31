<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="f6689_haeilmot.aspx.cs" Inherits="f6689_haeilmot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:SqlDataSource runat="server" ID="srcIlm" ConnectionString="Data Source=eight.labranet.jamk.fi;Initial Catalog=DemoxOy;Persist Security Info=True;User ID=koodari;Password=koodari13"
        SelectCommand="SELECT asioid, lastname, firstname, date FROM lasnaolot WHERE course like 'IIO13200%' ORDER BY asioid"></asp:SqlDataSource>

    <h1>Läsnäolot</h1>

    Sukunimi:<asp:TextBox ID="txt" runat="server"></asp:TextBox><br />
    Opintojakso:<asp:DropDownList ID="drop" runat="server"></asp:DropDownList><br />
    <asp:Button ID="btn" runat="server" Text="Hae" OnClick="btn_Click" />

    <asp:RegularExpressionValidator ID="regex" runat="server" ValidationExpression="^[a-öA-Ö]*$" ErrorMessage="Sukunimi voi sisältää vain kirjaimia" ControlToValidate="txt"></asp:RegularExpressionValidator>

    
    <asp:GridView ID="grid" runat="server"></asp:GridView>
    
</asp:Content>

