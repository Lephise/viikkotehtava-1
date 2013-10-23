<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="viikkotehtava5b.aspx.cs" Inherits="viikkotehtava5b" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

   
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <h2>      
      <asp:Label runat="server" ID="lblName"></asp:Label>
    </h2>


   <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="~/App_Data/XMLs.xml"></asp:XmlDataSource>

    
            
            <asp:Image runat="server" ID="image" Width="90px" Height="90px" /> <br />

            CD: 
            <asp:Label runat="server" id="lblCD" >
               

            </asp:Label>

    <br />
            
            ISBN:
            <asp:Label runat="server" id="LblISBN" db="XmlDataSource2">
      

            </asp:Label>

       
    <br />

    <div id="biisiaa" runat="server">
        Biisit: <br />
    </div>
    



</asp:Content>