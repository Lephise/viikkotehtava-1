<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="f6689_SQLdemo.aspx.cs" Inherits="f6689_SQLdemo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:BulletedList ID="BulletedList1" runat="server" Height="250px" Width="200px">
    </asp:BulletedList>
    <asp:SqlDataSource ID="srcMovies" ConnectionString="Data Source=eight.labranet.jamk.fi;Initial Catalog=Movie;Persist Security Info=True;User ID=koodari;Password=koodari13"
    SelectCommand="SELECT title, director, year FROM movies ORDER BY title"
    runat="server">
    </asp:SqlDataSource>
    
    <asp:GridView ID="GridView1" runat="server" DataSourceID="srcMovies">
    </asp:GridView>
    <h1>DataList</h1>
    
    <asp:DataList ID="DataList1" runat="server" DataSourceID="srcMovies">
        <ItemTemplate>
            Elokuvan <%#Eval ("title") %> on ohjannut <%#Eval ("director") %>
        </ItemTemplate>
    
    </asp:DataList>
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="srcMovies">
        <ItemTemplate>
            Elokuvan <%#Eval ("title") %> on ohjannut <%#Eval ("director") %>
        </ItemTemplate>
    </asp:Repeater>

    <asp:ListView ID="ListView1" runat="server" DataSourceID="srcMovies">
        <LayoutTemplate>
            <div id="itemPlaceholder" runat="server" />
            <asp:DataPager ID="pager1" PageSize="4" runat="server">
                <Fields>
                    <asp:NumericPagerField />
                </Fields>
            </asp:DataPager>
        </LayoutTemplate>
        <ItemTemplate>
            Elokuvan <%#Eval ("title") %> on ohjannut <%#Eval ("director") %>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>


