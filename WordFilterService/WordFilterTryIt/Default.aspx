<%@ Page Title="Word Filter Service: " Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WordFilterTryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel runat="server" ID="ServiceInfo" CssClass="jumbotron" BorderWidth="5">
        <h1><b>Word Filter Try It Page</b></h1>
        <br />
        <h3>This webpage allows the user to enter a string of their choosing into the Text Box and process it with the "Word Filter"
            service. The service takes the user entered string, and then removes occurances of "stop words" from the string,
            and returns it to the user.
        </h3>
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
        <asp:Label Text="Processed String: " runat="server" Font-Bold="True" />
        <asp:Label ID="output" Text="" runat="server" />
        
    </asp:Panel>

</asp:Content>
