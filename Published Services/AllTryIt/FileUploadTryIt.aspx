<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FileUploadTryIt.aspx.cs" Inherits="AlltryItPages.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    


    <asp:Panel runat="server" ID="ServiceInfo" CssClass="jumbotron" BorderWidth="5">
        <h1><b>File Upload Try It Page</b></h1>
        <br />
        <h3><b>Section 1</b> allows a user to select a local file from their computer and upload it to the web server. The server returns a link to the uploaded
            file so that the user may use that link to retrieve the file later.
        </h3>
        <h3><b>Section 2</b> allows the user to enter a URL of a webpage that they would like to download and save to the server. The server returns a link
            to the saved webpage inside of the server.
        </h3>
        <br />
        <h4>*NOTE* This is simply a basic TryIt page to demonstrate the core functionality of this web service. A more "realistic" GUI and service functionality
            will be created during the final portion of this project, when all the services get used together for a "practical" application.
        </h4>
        <br />
    </asp:Panel>

    <%--<asp:Panel runat="server" ID="Section1" CssClass="jumbotron" BorderWidth="5">
        <h2><b>Section 1: Local File Upload</b></h2>
        <br />
        <br />
        <p><b>Select a file for uploading:</b></p>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Button ID="saveFileButton" runat="server" onclick="saveFileButton_Click" Text="Save File" Font-Bold="True" />
        <br />
        <br />
        <asp:Label ID="statusLabel" Text="No file has been saved yet." runat="server" Font-Size="Large"></asp:Label>
        <br />
        <br />
        <asp:Label Text="Saved at URL: " runat="server" Font-Size="Large" Font-Bold="True" />
        <asp:HyperLink ID="fileSavedURL" Text=""  runat="server"  Font-Size="Large" NavigateUrl=""/>
        <p>(Copy and paste URL into browser to view file)</p>
        
    </asp:Panel>--%>

    <asp:Panel runat="server" ID="Section2" CssClass="jumbotron" BorderWidth="5">
        <h2><b>Section 2: Webpage Saver</b></h2>
        <br />
        <br />
        <p><b>Enter a valid URL to save to the server:</b></p>
        <asp:TextBox ID="webPageURL" runat="server" Width="800" />
        <asp:Button ID="webPageButton" onclick="webPageButton_Click" Text="Save Page" runat="server"  Font-Bold="True"/>
        <br />
        <br />
        <asp:Label ID="webpageStatusLabel" Text="A webpage has not been saved yet." runat="server" Font-Size="Large"></asp:Label>
        <br />
        <br />
        <asp:Label Text="Saved at URL: " runat="server" Font-Size="Large" Font-Bold="True" />
        <asp:HyperLink ID="webPageSavedURL" Text=""  runat="server"  Font-Size="Large" NavigateUrl=""/>
        
    </asp:Panel>
    <br />
    <br />
    <asp:Panel runat="server" CssClass="jumbotron" BorderWidth="5">
        <h3>Author: Carter Chamberlin</h3>
        <h3>Assignment: Project 3, Phase II</h3>
        <h3>Group: Group #16 (Carter & Chloe)</h3>
        <h3>Date: 31st March 2019</h3>
    </asp:Panel>
</asp:Content>
