using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TestRequiredService1(object sender, EventArgs e)
    {
        Label37.Visible = false;
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        string output = client.verification(rs1str.Text, rs1str0.Text);
        Label37.Text = output;
        Label37.Visible = true;
    }


    protected void TestRequiredService2(object sender, EventArgs e)
    {
        Label38.Visible = false;
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        string output = client.xPathSearch(rs1str1.Text, rs1str2.Text);
        if(output.Equals(""))
        {
            Label38.Text = "Invalid Path expression";
            Label38.Visible = true;
            return;
        }
        Label38.Text = output;
        Label38.Visible = true;

    }
}
