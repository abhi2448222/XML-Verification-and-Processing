<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CSE 445 - Homework 4 Part 1 Submission - Abhishek Rao (1210425135)</h1>
        Enter the URL of the XML file
        :
        <asp:TextBox ID="TextBox1" runat="server" Width="740px">http://www.public.asu.edu/~arao23/Hotels.xml</asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="137px" />
        <br />
        Generated XML Content :<br />
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
   
        <br />
    </div>
</asp:Content>
