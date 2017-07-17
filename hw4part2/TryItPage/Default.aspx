<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    </asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        cse 445 - AssignMent 4 - Abhishek Rao (1210425135)</h2>
    <div id="rs1" style="border: 1px dashed grey; padding-left: 20px; padding-bottom: 20px; margin-top: 10px;">
        <p><strong>Service 1 </strong>: <strong>Verification of XML file with its corresponding XSD file</strong></p>
        <p>URL : http://localhost:13502/Service1.svc</p>
        <p>Method Signature : string verification(string xmlPath, string xsdPath);</p> 
        <p><span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,sans-serif;mso-ascii-theme-font:minor-latin;mso-fareast-font-family:
SimSun;mso-fareast-theme-font:minor-fareast;mso-hansi-theme-font:minor-latin;
mso-bidi-font-family:&quot;Times New Roman&quot;;mso-bidi-theme-font:minor-bidi;
mso-ansi-language:EN-US;mso-fareast-language:ZH-CN;mso-bidi-language:AR-SA">Description : </span>Verify XML file with its schema and displays corresponding error if there are any or else displays &quot;No error&quot;</p>
        <p>
            <label>Enter XMLFile URL&nbsp;</label>&nbsp;
            <asp:TextBox ID="rs1str" Width="499px" runat="server" style="margin-left: 33px" >http://www.public.asu.edu/~arao23/Hotels.xml</asp:TextBox>
            &nbsp;</p>
        <p>
            Enter XMLSchema&nbsp; URL&nbsp;
            <asp:TextBox ID="rs1str0" Width="498px" runat="server" style="margin-left: 8px" >http://www.public.asu.edu/~arao23/Hotels.xsd</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" Text="submit" OnClick="TestRequiredService1" runat="server" Width="138px" style="margin-left: 181px" />
        </p>

            <asp:Label ID="Label37" runat="server" Font-Bold="True" Font-Size="Large" Visible="False"></asp:Label>

        &nbsp;&nbsp;<br />
        <br />
        <p><strong>Service 2 </strong>: <strong>XPathSearch of a XML file</strong></p>
        <p>URL : http://localhost:17325/Service1.svc</p>
        <p>Method Signature : string xPathSearch(string url, string pathExpr);</p> 
        <p><span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,sans-serif;mso-ascii-theme-font:minor-latin;mso-fareast-font-family:
SimSun;mso-fareast-theme-font:minor-fareast;mso-hansi-theme-font:minor-latin;
mso-bidi-font-family:&quot;Times New Roman&quot;;mso-bidi-theme-font:minor-bidi;
mso-ansi-language:EN-US;mso-fareast-language:ZH-CN;mso-bidi-language:AR-SA">Description : </span>This service returns the path expression value of the given path of a given XML file</p>
        <p>
            <label>Enter XMLFile URL&nbsp;</label>&nbsp;
            <asp:TextBox ID="rs1str1" Width="499px" runat="server" style="margin-left: 33px" >http://www.public.asu.edu/~arao23/Hotels.xml</asp:TextBox>
            &nbsp;</p>
        <p>
            Enter Path Expression&nbsp;
            <asp:TextBox ID="rs1str2" Width="498px" runat="server" style="margin-left: 18px" />
        </p>
        <p>
            <asp:Button ID="Button2" Text="submit" OnClick="TestRequiredService2" runat="server" Width="138px" style="margin-left: 181px" />
        </p>

            <asp:Label ID="Label38" runat="server" Font-Bold="True" Font-Size="Large" Visible="False"></asp:Label>

        &nbsp;&nbsp;<br />
        
    </div>

    
</asp:Content>
