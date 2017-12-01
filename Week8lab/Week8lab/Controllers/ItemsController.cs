using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Xml.XPath;
using Week8lab.Models;

namespace Week8lab.Controllers
{
    public class ItemsController : ApiController
    {
        // GET: api/Items
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Items/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Items
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Items/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Items/5
        public void Delete(int id)
        {
        }
        public int GetNumberOfOrders()
        {
            //do first
            string directory = HttpContext.Current.Server.MapPath("~");
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
            NodeIter = nav.Select("//PartNo[text()='" + sPartNo + "']");
            while (NodeIter.MoveNext())
            {
                numOrders++;
            }
            return numOrders;
        }
        Item[] GetItemListForOrder(int OrderID)
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
            Item[] oItemInfo = new Item[NodeIter.Count];

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
