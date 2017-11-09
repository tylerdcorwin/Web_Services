using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_midtermpt2_
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        Item[] GetItemListForOrder(int OrderID);

        [OperationContract]
        orderID getOrder(int OrderID);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    public class Item
    {
        [DataMember]
        public string Options;
        [DataMember]
        public string Cost;
        [DataMember]
        public string Name;
        [DataMember]
        public string Sku;        
    }

    public class orderID
    {
        [DataMember]
        public string OrderID;
    }
    public class Order
    {
        [DataMember]
        public int OrderID;
        [DataMember]
        public Item[] myItems;
    }
}
