using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Problem3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter, NodeIter2;

            string strExpression;
            strExpression = "//catalog_item[price < 40]";

            string strExpression2;
            strExpression2 = "//catalog_item[size[@description = \"Small\"]]";

            //XML file needs to be in the debug folder!
            string xmlFile = Application.StartupPath + "\\catalog-1.xml";
            docNav = new XPathDocument(xmlFile);
            nav = docNav.CreateNavigator();

            NodeIter = nav.Select(strExpression);
            NodeIter2 = nav.Select(strExpression2);
          
            StringBuilder itemResult = new StringBuilder();
            while (NodeIter.MoveNext())
            {
                itemResult.AppendLine(NodeIter.Current.SelectSingleNode("price").Value + "-" + NodeIter.Current.SelectSingleNode("@gender").Value);
                itemResult.AppendLine(" ");
            };
            txtPrice.Text = itemResult.ToString();


            StringBuilder itemResult2 = new StringBuilder();
            while (NodeIter2.MoveNext())
            {
                itemResult2.AppendLine(NodeIter2.Current.SelectSingleNode("item_number").Value);
                itemResult2.AppendLine(" ");
            };
            txtItemNum.Text = itemResult2.ToString();
        }
    }
}
