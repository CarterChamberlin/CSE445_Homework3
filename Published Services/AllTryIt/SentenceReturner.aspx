<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SentenceReturner.aspx.cs" Inherits="AlltryItPages.SentenceReturner" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:Panel runat="server" CssClass="jumbotron" BorderWidth="5">
            <span class="auto-style1"><strong>Sentences Containing Keyword</strong></span><br />
            <br />
            This web service will take in a URL and a key word from a user
            <br />
            and return all sentences from the web site containing this word.<br />
            <br />
            URL:
            <asp:TextBox ID="TextBox1" runat="server" Width="322px"></asp:TextBox>
            <br />
            Word:
            <asp:TextBox ID="TextBox2" runat="server" Width="114px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>

        
    </asp:Panel>

</asp:Content>
