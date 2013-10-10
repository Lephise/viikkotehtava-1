<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="f6689_valipalaute.aspx.cs" Inherits="f6689_valipalaute" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Anna Palaute</h1>
    <b>Pvm: </b><asp:TextBox ID="pvm" runat="server" /><br />
    <b>Nimi: </b><asp:TextBox ID="nimi" runat="server" /><br />
    <b>Olen oppinut: </b><asp:TextBox ID="oppinut" runat="server" /> <br />
    <b>Haluan oppia: </b><asp:TextBox ID="haluan" runat="server" /> <br />
    <b>Hyvää: </b><asp:TextBox ID="hyvaa" runat="server" /> <br />
    <b>Parannettavaa: </b><asp:TextBox ID="paran" runat="server" /> <br />
    <b>Muuta: </b><asp:TextBox ID="muuta" runat="server" /> <br />
    <asp:Button ID="myBtn" runat="server" Text="Lähetä Palaute" OnClick="myBtn_Click" />

    <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
        ControlToValidate="pvm"
        ErrorMessage="Pvm is a required field."
        ForeColor="Red">
    </asp:RequiredFieldValidator>

    <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
        ControlToValidate="nimi"
        ErrorMessage="Nimi is a required field."
        ForeColor="Red">
    </asp:RequiredFieldValidator>

    <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server"
        ControlToValidate="oppinut"
        ErrorMessage="Olen Oppinut is a required field."
        ForeColor="Red">
    </asp:RequiredFieldValidator>

    <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server"
        ControlToValidate="haluan"
        ErrorMessage="Haluan oppia is a required field."
        ForeColor="Red">
    </asp:RequiredFieldValidator>
   
     <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server"
        ControlToValidate="hyvaa"
        ErrorMessage="Hyvää is a required field."
        ForeColor="Red">
    </asp:RequiredFieldValidator>

    <asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server"
        ControlToValidate="paran"
        ErrorMessage="Parannettavaa is a required field."
        ForeColor="Red">
    </asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator 
       id="pvmValidator" runat="SERVER" 
       ControlToValidate="pvm" 
       ErrorMessage="Syötä päivämäärä muotoa dd/mm/yyyy"
       ValidationExpression="\d{2}\.\d{2}\.\d{4}?">
     </asp:RegularExpressionValidator>

    <asp:RegularExpressionValidator 
       id="RegularExpressionValidator1" runat="SERVER" 
       ControlToValidate="nimi" 
       ErrorMessage="Nimessä ei ole numeroita"
       ValidationExpression="^[a-zA-Z ]*$">
     </asp:RegularExpressionValidator>
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

    
</asp:Content>

