using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml.XPath;

namespace OrderServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class OrderService : IOrderService
    {
        public int GetNumberOfOrders()
        {
            //do first
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "orderInfoLab3.xml";
            XPathDocument docNav;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;
            docNav = new XPathDocument(strFilename);
            nav = docNav.CreateNavigator();
            //XPath varible search in doc
            string varString;        
            varString = "//Order";
            int count = 0;
            //Iterate through number of orders
            NodeIter = nav.Select(varString);
            count = NodeIter.Count;     
            return count;            
        }

        public double GetTotalCostForAnOrder(int OrderID)
        {
            //do first
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "orderInfoLab3.xml";
            XPathDocument docNav;
            XPathNavigator nav;
            docNav = new XPathDocument(strFilename);
            nav = docNav.CreateNavigator();
            //XPath varible search in doc
            double total = (double)
            nav.Evaluate("sum(//Order[@id=" + OrderID + "]/Items/Item/TotalCost)");
            return total;
        }

        public int HowManyOrderedForAPartNo(string sPartNo)
        {
            //do first
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "orderInfoLab3.xml";
            XPathDocument docNav;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;
            docNav = new XPathDocument(strFilename);
            nav = docNav.CreateNavigator();
            //XPath varible search in doc
            int numOrders = 0;            
            NodeIter = nav.Select("//PartNo[text()='" + sPartNo +"']");
            while (NodeIter.MoveNext())
            {
                numOrders++;
            }
            return numOrders;
        }

        BillingInformation IOrderService.GetBillinAddressForAnOrder(int OrderID)
        {
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "orderInfoLab3.xml";
            XPathDocument docNav;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;
            docNav = new XPathDocument(strFilename);
            nav = docNav.CreateNavigator();
            //XPath varible search in doc
            string varString;
            varString = "//Order[@id=" + OrderID + "]/BillingInformation";
            //Iterate through number of orders
            NodeIter = nav.Select(varString);
            XPathNavigator myNav = nav.SelectSingleNode(varString);
            //get values
            BillingInformation newInfo = new BillingInformation();
            newInfo.Name = myNav.SelectSingleNode("Name").Value;
            newInfo.Address = myNav.SelectSingleNode("Address").Value;
            newInfo.City = myNav.SelectSingleNode("City").Value;
            newInfo.State = myNav.SelectSingleNode("State").Value;
            newInfo.ZipCode = myNav.SelectSingleNode("ZipCode").Value;

            return newInfo;
        }

        Item[] IOrderService.GetItemListForOrder(int OrderID)
        {            
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "orderInfoLab3.xml";
            XPathDocument docNav;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;
            XPathNodeIterator NodeIter2;
            docNav = new XPathDocument(strFilename);
            nav = docNav.CreateNavigator();
            //XPath varible search in doc
            string varString;
            varString = "//Order[@id=" + OrderID + "]/Items/Item";
            //Iterate through number of orders
            NodeIter = nav.Select(varString);
            Item[] oItemInfo = new Item[NodeIter.Count ];
          
            XPathNavigator myNav = nav.SelectSingleNode(varString);
            int i = 0;
            while (NodeIter.MoveNext())
            {
                Item newItem = new Item();
                newItem.PartNo = NodeIter.Current.SelectSingleNode("PartNo").Value;
                newItem.Description = NodeIter.Current.SelectSingleNode("Description").Value;
                newItem.UnitPrice = NodeIter.Current.SelectSingleNode("UnitPrice").Value;
                newItem.Quantity = NodeIter.Current.SelectSingleNode("Quantity").Value;
                newItem.TotalCost = NodeIter.Current.SelectSingleNode("TotalCost").Value;

                NodeIter2 = NodeIter.Current.Select("CustomerOptions");
                while (NodeIter2.MoveNext())
                {
                    XPathNavigator custNav = NodeIter2.Current;
                    int count = NodeIter2.Current.SelectChildren(XPathNodeType.Element).Count;
                    if (count > 0)
                    {
                        newItem.Size = custNav.SelectSingleNode("Size").Value;
                        newItem.Color = custNav.SelectSingleNode("Color").Value;
                    } //else add blank strings to the other items
                    else
                    {
                        newItem.Size = "";
                        newItem.Color = "";
                    }
                }
                oItemInfo[i] = newItem;
                i++;
            }
            return oItemInfo;
        } 
    }
}
