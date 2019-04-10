<%@ Page Title="Link Service" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LinkService.aspx.cs" Inherits="AlltryItPages.LinkService" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <asp:Panel runat="server" ID="ServiceInfo" CssClass="jumbotron" BorderWidth="5">
        <h2><b>Link Retriever Try It Page</b></h2>
        <br />
        <h4>This allows the user to enter a URL of a webpage that they would like to have processed by the web service. The web service will 
            pull all the links inide "a:href" tags from the body content of the html page. Each link gets added to a list, and them the page title of the 
            individual links is pulled and added to a separate list. The service then uses the information from both lists to construct a properly formatted "a:href" 
            tag for each link, with the inner text being the title of the link page, and the href redirect being the link itself.
        </h4>
        <br />
        <h4>The proposed purpose of this service is to allow a user to get all refenced works and web-pages from the main content of an article, web-page, or 
            really any html document they wish to analyze. This can allow the user to know more information about the refenced works without having to open each href 
            manually from the original html page.
        </h4>
        <br />
    </asp:Panel>

     <asp:Panel runat="server" ID="userInput" CssClass="jumbotron" BorderWidth="5">
         <h3><b>User Input</b></h3>
         <asp:Label Text="Enter URL below:" runat="server"  Font-Bold="True" Font-Size="Large" />
         <br />
         <asp:TextBox ID="urlInput" runat="server" Width="800" />
         <br />
         <asp:Button Text="Submit" OnClick="Submit_Click" runat="server" />
    </asp:Panel>

    <asp:Panel runat="server" ID="programOutput" CssClass="jumbotron" BorderWidth="5">
        <h3><b>Program Output:</b></h3>
        <br />
        <h4>Below are all the links from the main content of the web URL entered above:</h4>
        <hr />
        <asp:Label Text="" ID="linkedURLs" runat="server" />
        
    </asp:Panel>
</asp:Content>
