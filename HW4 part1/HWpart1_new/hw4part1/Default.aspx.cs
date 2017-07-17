using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class _Default : Page
{
    StringBuilder builder = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Label1.Visible = false;
            XmlDocument doc = new XmlDocument();
            doc.Load(TextBox1.Text);
            XmlNode node = doc.DocumentElement;
            OutputNode(node);
            Label1.Visible = true;
            Label1.Text = builder.ToString();
            builder.Clear();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Label1.Visible = true;
            Label1.Text = ex.Message;
        }
    }

     void OutputNode(XmlNode node)    // recursive
    {
        if (node == null)
            System.Environment.Exit(1);

        //TextBox2.Text = string.Format("Type={0}\tName={1}\tValue={2}", node.NodeType, node.Name, node.Value);
        if(node.Name== "Hotel")
            builder.Append(string.Format("Type={0}&nbsp&nbsp&nbspName={1}&nbsp&nbsp&nbspValue={2}&nbsp&nbsp&nbspAttributeName={3}&nbsp&nbsp&nbspAttributeValue={4}", node.NodeType, node.Name, node.Value,node.Attributes[0].Name, node.Attributes[0].Value)).Append("<br/>");
        else if(node.Name== "Buslines")
            builder.Append(string.Format("Type={0}&nbsp&nbsp&nbspName={1}&nbsp&nbsp&nbspValue={2}&nbsp&nbsp&nbspAttributeName={3}&nbsp&nbsp&nbspAttributeValue={4}", node.NodeType, node.Name, node.Value, node.Attributes[0].Name, node.Attributes[0].Value)).Append("<br/>");
        else
            builder.Append(string.Format("Type={0}&nbsp&nbsp&nbspName={1}&nbsp&nbsp&nbspValue={2}", node.NodeType, node.Name, node.Value)).Append("<br/>");

        if (node.HasChildNodes)
        {
            XmlNodeList children = node.ChildNodes;
           
            foreach (XmlNode child in children)
                OutputNode(child);
        }
    }
}