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
    public class AddressController : ApiController
    {
        // GET: api/Address
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Address/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Address
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Address/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Address/5
        public void Delete(int id)
        {
        }
        [HttpGet]
        [ActionName("GetBillinAddressForAnOrder")]
        public BillingAddress GetBillinAddressForAnOrder(int OrderID)
        {
            string directory = HttpContext.Current.Server.MapPath("~");
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
            BillingAddress newInfo = new BillingAddress();
            newInfo.Name = myNav.SelectSingleNode("Name").Value;
            newInfo.Address = myNav.SelectSingleNode("Address").Value;
            newInfo.City = myNav.SelectSingleNode("City").Value;
            newInfo.State = myNav.SelectSingleNode("State").Value;
            newInfo.ZipCode = myNav.SelectSingleNode("ZipCode").Value;

            return newInfo;
        }
    }
}
