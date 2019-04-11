<%@ Page Title="Translation Service" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="translationService.aspx.cs" Inherits="AlltryItPages.translationService" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel runat="server" ID="ServiceInfo" CssClass="jumbotron" BorderWidth="5">
        <h2><b>Translation Try It Page</b></h2>
        <br />
        <h4>This program currently allows a user to enter a string of textL, and have it translated into Spanish, and returned back to them.
            In the final iteration of this project (Homework 5), this particular service should allow the user to specify whichever language they please.
            Eventually this will work with web pages in Homework 5.
        </h4>
        <br />
    </asp:Panel>

     <asp:Panel runat="server" ID="userInput" CssClass="jumbotron" BorderWidth="5">
        <h3><b>User Input</b></h3>
        <asp:Label Text="Enter String below:" runat="server"  Font-Bold="True" Font-Size="Large" />
        <br />
        <asp:TextBox ID="textInput" runat="server" Width="800" />
        <asp:Button Text="Submit" OnClick="Submit_Click" runat="server" />
        <br />
        
         
    </asp:Panel>

    <asp:Panel runat="server" ID="programOutput" CssClass="jumbotron" BorderWidth="5">
        <h3><b>Program Output:</b></h3>
        <br />
        <h4>Below is the original string translated into Spanish: </h4>
        <hr />
        <asp:Label Text="" ID="translatedLabel" runat="server" />
        
    </asp:Panel>

</asp:Content>