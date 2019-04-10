<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Top10ContentWords.aspx.cs" Inherits="AlltryItPages.Top10ContentWords" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Panel runat="server" CssClass="jumbotron" BorderWidth="5">
            This web service analyzes a webpage given&nbsp; a URL input and returns the 10 most
            <br />
            frequently occuring content words in order from most frequent to least frequent.<br />
            <br />
            URL:
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="410px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Enter" />
            <br />
            <br />
            <asp:Label ID="topLabel" runat="server" Font-Bold="True">Top 10 Content Words:</asp:Label>
            <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </asp:Panel>
    



</asp:Content>