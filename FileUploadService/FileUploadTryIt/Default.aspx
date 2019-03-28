<%@ Page Title="Home: " Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FileUploadTryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="ServiceInfo">
        <h1>File Upload Try It Page</h1>
        <p>This page allows the user to select a local file from their system, and upload it to the server with  a user specified filename.
            This service used the File Upload RESTful service developed as part of this project.
        </p>
        <br />
    </div>

    <asp:Panel runat="server" ID="userInput" CssClass="jumbotron">
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="saveButton" runat="server" onclick="saveButton_Click" Text="Save File" />
        <br />
        <asp:Label ID="statusLabel" runat="server" Text="File has not been uploaded yet."></asp:Label>
        <br />
        <asp:Label Text="Saved at URL: " runat="server" />
        <asp:TextBox runat="server" />
    </asp:Panel>

    <asp:Panel runat="server" ID="programResponse" CssClass="jumbotron">
        
    
    </asp:Panel>

</asp:Content>
