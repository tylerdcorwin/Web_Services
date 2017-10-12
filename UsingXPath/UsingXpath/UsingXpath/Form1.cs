using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace UsingXpath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
           
            String strExpression;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\books.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            // Find the average cost of a book.
            // This expression uses standard XPath syntax.
            strExpression = txtXPathExpression.Text;

            // Use the Evaluate method to return the evaluated expression.
           lblResults.Text = nav.Evaluate(strExpression).ToString();
            
            
           



        }

        private void btnGetNodes_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
           
            // Open the XML.
            string xmlFile = Application.StartupPath + "\\books.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            
            // Select the node and place the results in an iterator.
            NodeIter = nav.Select(txtNodeList.Text);

            cmbNodes.Items.Clear();

            //Iterate through the results showing the element value.
            while (NodeIter.MoveNext())
            {
                cmbNodes.Items.Add(NodeIter.Current.Value);
                // if you use  /bookstore/book, then child
                XPathNodeIterator KidNodeIter;
                KidNodeIter = NodeIter.Current.Select("first-name");
                //if you remove the 2nd while loop you eliminate the first name duplicates
                while (KidNodeIter.MoveNext())
                     cmbNodes.Items.Add(KidNodeIter.Current.Value);
                };
        }
    }
}
