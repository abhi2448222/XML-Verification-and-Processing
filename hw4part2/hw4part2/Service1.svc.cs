using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

namespace hw4part2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        int flag = 0;
        string output = "";
        string output2 = "";

        public string verification(string xmlPath, string xsdPath)
        {
            output = "";
            try
            {
               
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas.Add(null, xsdPath);
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                settings.ValidationEventHandler += new ValidationEventHandler(validate);
                settings.IgnoreWhitespace = true;


                XmlReader hotels = XmlReader.Create(xmlPath, settings);


                while (hotels.Read()) {}
                
            }
            catch(Exception e)
            {
                return e.Message;
            }
            if (flag == 0)
                return "No Error";
            return output;

        }
        public string xPathSearch(string url, string pathExpr)
        {
            output2 = "";
            try
            {
                //Read the document using path expression
                XPathDocument dx = new XPathDocument(url);
                XPathNavigator nav = dx.CreateNavigator();
                XPathNodeIterator iterator = nav.Select(pathExpr);
                while (iterator.MoveNext())
                {
                    string element = iterator.Current.Value;
                    output2 += element + "<br/>";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return output2;
        }

        //Validate the error in the document
        private void validate(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
            {
                Console.WriteLine(" Warning" + e.Message);
                output += e.Message;
            }
            else
            {
                Console.WriteLine(" Error message" + e.Message);
                output += e.Message;
            }
            flag = 1;
        }
    }
}

