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
using System.IO;

namespace XML_HTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\contact.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList contacts = xmlDoc.GetElementsByTagName("ContactDB");
            XmlNodeList contact = xmlDoc.GetElementsByTagName("Contacts");
            XmlNodeList version = xmlDoc.GetElementsByTagName("VersionNumber");

            
            foreach (XmlNode date in version)
            {
                lblVersion.Text = date.InnerText;
            }

            // Now you can check each node of the list
            foreach (XmlNode node in contact)
            {
                
                foreach(XmlNode child in node.ChildNodes)
                {
                    lblResults.Text += child.Name + ": " + child.InnerText + "\n\n";
                }
                lblResults.Text += "Sex " + node.Attributes["sex"].Value + "\n\n";
                
            }            
        }
    }
}
