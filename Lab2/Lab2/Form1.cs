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

namespace Lab2
{
    public partial class Form1 : Form
    {
        //Global Variables
        XPathNavigator nav;
        XPathNavigator custNav;
        XPathDocument docNav;
        XPathNodeIterator NodeIterBilling;
        XPathNodeIterator NodeIterShipping;
        XPathNodeIterator NodeIterItems;
        XPathNodeIterator NodeIterCustOpt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Open XML
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            docNav = new XPathDocument(xmlFile);
            nav = docNav.CreateNavigator();
            //params
            string billingInfo = "//BillingInformation";
            NodeIterBilling = nav.Select(billingInfo);
            string shippingInfo = "//ShippingInformation";
            NodeIterShipping = nav.Select(shippingInfo);
            string itemInfo = "//Item";
            NodeIterItems = nav.Select(itemInfo);             
            
            //show
            while (NodeIterBilling.MoveNext())
            {
                lbBilling.Items.Add(NodeIterBilling.Current.SelectSingleNode("Name").Value);
                lbBilling.Items.Add(NodeIterBilling.Current.SelectSingleNode("Address").Value);
                lbBilling.Items.Add(NodeIterBilling.Current.SelectSingleNode("City").Value);
                lbBilling.Items.Add(NodeIterBilling.Current.SelectSingleNode("State").Value);
                lbBilling.Items.Add(NodeIterBilling.Current.SelectSingleNode("ZipCode").Value);
            }
            while (NodeIterShipping.MoveNext())
            {
                lbShipping.Items.Add(NodeIterShipping.Current.SelectSingleNode("Name").Value);
                lbShipping.Items.Add(NodeIterShipping.Current.SelectSingleNode("Address").Value);
                lbShipping.Items.Add(NodeIterShipping.Current.SelectSingleNode("City").Value);
                lbShipping.Items.Add(NodeIterShipping.Current.SelectSingleNode("State").Value);
                lbShipping.Items.Add(NodeIterShipping.Current.SelectSingleNode("ZipCode").Value);
            }            
            while (NodeIterItems.MoveNext())
            {
                lbItem.Items.Add(NodeIterItems.Current.SelectSingleNode("PartNo").Value);
                lbItem.Items.Add(NodeIterItems.Current.SelectSingleNode("Description").Value);
                lbItem.Items.Add(NodeIterItems.Current.SelectSingleNode("UnitPrice").Value);
                lbItem.Items.Add(NodeIterItems.Current.SelectSingleNode("Quantity").Value);
                lbItem.Items.Add(NodeIterItems.Current.SelectSingleNode("TotalCost").Value);

                NodeIterCustOpt = NodeIterItems.Current.Select("CustomerOptions");
                while (NodeIterCustOpt.MoveNext())
                {
                    custNav = NodeIterCustOpt.Current;
                    int count = NodeIterCustOpt.Current.SelectChildren(XPathNodeType.Element).Count;
                    if (count > 0)
                    {
                        lbItem.Items.Add(custNav.SelectSingleNode("Size").Value);
                        lbItem.Items.Add(custNav.SelectSingleNode("Color").Value);                        
                    }
                }
                
                lbItem.Items.Add("===============================");
            }
            //get counts
            double total = (double)
                nav.Evaluate("sum(Order/Items/Item/TotalCost)");
            lblCostResult.Text = total.ToString();

            double itemz = (double)
                nav.Evaluate("count(Order/Items/Item)");
            lblItemResult.Text = itemz.ToString();            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
