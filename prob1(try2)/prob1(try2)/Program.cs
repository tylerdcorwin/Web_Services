using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace prob1_try2_
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            string url = "http://34.229.220.156/FootballWebService/Footballservice.asmx/GetFootballTeam";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            nav = docNav.CreateNavigator();

            string player = "//Player[weight > 250]";
            NodeIter = nav.Select(player);          

            while (NodeIter.MoveNext())
            {                
                Console.WriteLine(NodeIter.Current.SelectSingleNode("name"));
                Console.WriteLine(NodeIter.Current.SelectSingleNode("weight"));                               
            }
            Console.ReadLine();
        }
    }
}
