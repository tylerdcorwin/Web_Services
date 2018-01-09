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
    public partial class cardChecker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Weather API KEY: 69b2a5c4bee93799
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CC.cdyne.LuhnChecker myCC = new CC.cdyne.LuhnChecker();
            CC.cdyne.ReturnIndicator myReturn = new CC.cdyne.ReturnIndicator();

            myReturn = myCC.CheckCC(TextBox1.Text);

            CCResult.Text = myReturn.CardType + " \n" + myReturn.CardValid;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dict.aonaware.WordDefinition myDict = new dict.aonaware.WordDefinition();
            dict.aonaware.DictService myService = new dict.aonaware.DictService();

            myDict = myService.Define(TextBox2.Text);
            dict.aonaware.Definition[] dict = myDict.Definitions;
            
            foreach(dict.aonaware.Definition d in dict)
            {
                ListBox1.Items.Add(d.WordDefinition);
                ListBox1.Items.Add("\n");
            }            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            XPathNodeIterator NodeIter2;
            //Create Request 

            String WeatherURL = "http://api.wunderground.com/api/69b2a5c4bee93799/conditions/q/MA/Boston.xml";

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

            string lat = "//observation_location";
            NodeIter = nav.Select(lat);

            string feels = "//current_observation";
            NodeIter2 = nav.Select(feels);
               
            while (NodeIter.MoveNext())
            {
                ListBox2.Items.Add(NodeIter.Current.SelectSingleNode("latitude").Value);
                ListBox2.Items.Add(NodeIter.Current.SelectSingleNode("longitude").Value);               
            }
            while (NodeIter2.MoveNext())
            {
                ListBox2.Items.Add(NodeIter2.Current.SelectSingleNode("feelslike_string").Value);
            }


        }
    }
}