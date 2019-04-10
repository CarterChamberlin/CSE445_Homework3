<%@ Page Title="Word Filter Service" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WordFilterTryIt.aspx.cs" Inherits="AlltryItPages.WordFilterTryIt" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:Panel runat="server" ID="ServiceInfo" CssClass="jumbotron" BorderWidth="5">
        <h1><b>Word Filter Try It Page</b></h1>
        <br />
        <h3>This webpage allows the user to enter a string of their choosing into the Text Box and process it with the "Word Filter"
            service. The service takes the user entered string, and then removes occurances of "stop words" from the string,
            and returns it to the user.
        </h3>
        <br />
        <h4>*NOTE* This is simply a basic TryIt page to demonstrate the core functionality of this web service. A more "realistic" GUI and service functionality
            will be created during the final portion of this project, when all the services get used together for a "practical" application.
        </h4>
        <br />
    </asp:Panel>

    <asp:Panel runat="server" ID="Section1" CssClass="jumbotron" BorderWidth="5">
        <h2><b>Stop Words Remover:</b></h2>
        <br />
        <br />
        <p><b>Enter a string for processing: </b></p>
        <asp:TextBox ID="userInput" runat="server" width="800"/>
        <br />
        <br />
        <asp:Button ID="sendString" runat="server" onclick="sendString_Click" Text="Go!" Font-Bold="True" />
        <br />
        <br />
        <asp:Label Text="Processed String: " runat="server" Font-Bold="True" Font-Size="Large" />
        <asp:Label ID="output" Text="" runat="server" Font-Size="Large" />
        
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
