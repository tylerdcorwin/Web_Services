using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;

namespace Problem1
{
    public partial class Banking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "";
            lblOwner.Text = "";
            lblAcntID.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;

            //Create Request
            string getBankInfo = "http://34.229.220.156/BankingService/Bankservice.asmx/GetBankInformation";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(getBankInfo);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            XPathNodeIterator NodeIter;
            XPathNodeIterator NodeIter2;
            string bankStuff;
            string accntStuff;
            bankStuff = "//BankInformation";
            accntStuff = "//AccountInfo";

            NodeIter = nav.Select(bankStuff);
            NodeIter2 = nav.Select(accntStuff);

            while (NodeIter.MoveNext())
            {
                lblOwner.Text += NodeIter.Current.SelectSingleNode("OwnerName").Value;
                lblAcntID.Text += NodeIter.Current.SelectSingleNode("AccountID").Value;
                //lblTotal.Text += NodeIter.Current.SelectSingleNode("//Amount").Value;                
            }
            double total = 0;
            string totalz = "";
            while (NodeIter2.MoveNext())
            {
                totalz = NodeIter2.Current.SelectSingleNode("Amount").Value;
                total += double.Parse(totalz);
            }
            lblTotal.Text = total.ToString();
        }
    }
}