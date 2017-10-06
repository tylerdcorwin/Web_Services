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

namespace ParseXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRevDate_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\Stocks.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();


            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList stocks = xmlDoc.GetElementsByTagName("RevisionDate");

            // Now you can check each node of the list
            foreach (XmlNode node in stocks)
            {
                Console.WriteLine(node.InnerText);
                results.AppendLine(node.InnerText);
            }
            txtResult.Text = results.ToString();
        }

        private void btnListName_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\Stocks.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();


            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList stocks = xmlDoc.GetElementsByTagName("Symbol");

            // Now you can check each node of the list
            foreach (XmlNode node in stocks)
            {
                Console.WriteLine(node.InnerText);
                results.AppendLine(node.InnerText);
            }
            txtResult.Text = results.ToString();
        }
    }
}
