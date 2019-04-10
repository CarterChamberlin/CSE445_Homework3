<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebReadingTime.aspx.cs" Inherits="AlltryItPages.WebReadingTime" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:Panel runat="server" CssClass="jumbotron" BorderWidth="5">
            
            <span class="auto-style2"><strong>Web Page Reading Time</strong></span><br />
            <br />
            This web service will return the approximate reading time<br />
            of a web page based on the reading speed (in words per minute)<br />
            of the user. It will also show the current time and the final time<br />
            after reading. Please enter a URL and your reading speed.<br />
            <br />
&nbsp;&nbsp;&nbsp; <span class="auto-style1">Reading Pace&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; WPM:&nbsp;&nbsp;&nbsp; </span>
            <br />
&nbsp;&nbsp;&nbsp; Below Average&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 100-199<br />
&nbsp;&nbsp;&nbsp; Average&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 200-249<br />
&nbsp;&nbsp;&nbsp; Above Average&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 250-499<br />
&nbsp;&nbsp;&nbsp; Speed Read&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 500+<br style="text-decoration: overline" />
            <br />
            URL:&nbsp;&nbsp;
            <asp:TextBox ID="urlBox" runat="server" style="margin-right: 38px" Width="264px"></asp:TextBox>
            <br />
            Read Speed (WPM) : <asp:TextBox ID="wpmBox" runat="server" style="margin-right: 0px" Width="63px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="89px" />
            <br />
            <asp:Label ID="TimeLabel" runat="server"></asp:Label>
            <br />
        
    </asp:Panel>

</asp:Content>
