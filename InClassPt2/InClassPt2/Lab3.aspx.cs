using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;

namespace InClassPt2
{
    public partial class Lab3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            XPathNodeIterator NodeIter2;
            //Create Request 

            String WeatherURL = "http://api.wunderground.com/api/69b2a5c4bee93799/forecast/q/MA/Boston.xml";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(WeatherURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            string fcstDay = "//forecastday";
            NodeIter = nav.Select(fcstDay);

            string feels = "//forecastday";
            NodeIter2 = nav.Select(feels);

            while (NodeIter.MoveNext())
            {
                TextBox1.Text += NodeIter.Current.SelectSingleNode("title");
                TextBox1.Text += "\n";
                TextBox1.Text += NodeIter.Current.SelectSingleNode("fcttext");
                TextBox1.Text += "\n\n";
                
            }
            /*
            while (NodeIter2.MoveNext())
            {
                lbResults.Items.Add(NodeIter2.Current.SelectSingleNode("fcttext").Value);
            }
            */

        }
    }
}