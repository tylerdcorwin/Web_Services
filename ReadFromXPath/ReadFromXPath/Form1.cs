using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;


namespace ReadFromXPath
{
    public partial class Form1 : Form
    {
        XPathNavigator nav;
        XPathDocument docNav;
        XPathNodeIterator NodeIter;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnDisplayVerDate_Click(object sender, EventArgs e)
        {
            //Open xml
            string xmlFile = Application.StartupPath + "\\contact.xml";
            docNav = new XPathDocument(xmlFile);        
            nav = docNav.CreateNavigator();
            //params
            string verDate = "//VersionDate";
            string verNumber = "//VersionNumber";
            //show
            lblDate.Text = nav.SelectSingleNode(verDate).Value;
            lblVer.Text = nav.SelectSingleNode(verNumber).Value;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //Open xml
            string xmlFile = Application.StartupPath + "\\contact.xml";
            docNav = new XPathDocument(xmlFile);        
            nav = docNav.CreateNavigator();
            //params
            string contacts = "//Contacts";
            NodeIter = nav.Select(contacts);
            //show
            while (NodeIter.MoveNext())
            {
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("firstname").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("lastname").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("phonenumber").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("faxnumber").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("email").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("./@sex").Value);
                lbResults.Items.Add("==================================");
            }
            
        }

        private void btnDisplayMale_Click(object sender, EventArgs e)
        {
            //Open xml
            string xmlFile = Application.StartupPath + "\\contact.xml";
            docNav = new XPathDocument(xmlFile);
            nav = docNav.CreateNavigator();
            //params
            string contacts = "//Contacts[@sex=\"M\"]";
            NodeIter = nav.Select(contacts);
            //show
            while (NodeIter.MoveNext())
            {
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("firstname").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("lastname").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("phonenumber").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("faxnumber").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("email").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("./@sex").Value);
                lbResults.Items.Add("==================================");
            }
        }

        private void btnDisplayLast_Click(object sender, EventArgs e)
        {
            //Open xml
            string xmlFile = Application.StartupPath + "\\contact.xml";
            docNav = new XPathDocument(xmlFile);
            nav = docNav.CreateNavigator();
            //params
            string lname = "//Contacts[lastname='" + txtLName.Text.ToString() + "']";
            NodeIter = nav.Select(lname);
            //show
            while (NodeIter.MoveNext())
            {
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("firstname").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("lastname").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("phonenumber").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("faxnumber").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("email").Value);
                lbResults.Items.Add(NodeIter.Current.SelectSingleNode("./@sex").Value);
                lbResults.Items.Add("==================================");
            }
        }
    }
}
