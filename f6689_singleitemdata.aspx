<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="f6689_singleitemdata.aspx.cs" Inherits="f6689_singleitemdata" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:SqlDataSource ID="srcMovies" ConnectionString="Data Source=eight.labranet.jamk.fi;Initial Catalog=Movie;Persist Security Info=True;User ID=koodari;Password=koodari13"
    SelectCommand="SELECT title, director, year FROM movies ORDER BY title"
    runat="server">
    </asp:SqlDataSource>

    <h1>DatControls to display a single data item</h1>
    <h2>DetailsView -control</h2>
    <p>Näyttääd ata HTML-taulussa, tarvittaessa mahdollista lisäämisen ja muokkaamisen</p>
    <asp:DetailsView ID="DetailsView1"
           DataSourceID="srcMovies" runat="server"
           AllowPaging="true">

    </asp:DetailsView>

    <h2>FormView-control</h2>
    <p>Näyttää data ItemTemplaten avulla</p>
    <asp:FormView ID="FormView1" DataSourceID="srcMovies" runat="server" AllowPaging="true">
        <ItemTemplate>
            <%#Eval ("title") %> ohjaaja <%#Eval ("director") %>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>

