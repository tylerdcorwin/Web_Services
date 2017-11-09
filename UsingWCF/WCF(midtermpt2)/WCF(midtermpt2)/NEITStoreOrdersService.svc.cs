using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_midtermpt2_
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IOrderService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Item[] GetItemListForOrder(int OrderID)
        {
            Order myOrder = new Order();
            Item[] myItems = new Item[2];

            Item myItem1 = new Item();
            myItem1.Name = "item1";
            myItem1.Options = "nothing";
            myItem1.Cost = "$25.00";
            myItem1.Sku = "0011447788";
            myItems[0] = myItem1;

            Item myItem2 = new Item();
            myItem2.Name = "item2";
            myItem2.Options = "some options";
            myItem2.Cost = "$35.00";
            myItem2.Sku = "5544887722";
            myItems[1] = myItem2;

            myOrder.myItems = myItems;
            //myItems[1] = myItem1;
            //return myItems[1];
            for (int i = 0; i < myItems.Length; i++)
            {

            }
            return myOrder[];
        }

        public orderID getOrder(int OrderID)
        {
            throw new NotImplementedException();
        }
    }
}
