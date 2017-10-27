using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OrderServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        //need to set OrderID, and sPartNo//
        [OperationContract]
        int GetNumberOfOrders();

        [OperationContract]
        double GetTotalCostForAnOrder(int OrderID);

        [OperationContract]
        Item[] GetItemListForOrder(int OrderID);

        [OperationContract]
        int HowManyOrderedForAPartNo(string sPartNo);

        [OperationContract]
        BillingInformation GetBillinAddressForAnOrder(int OrderID);        
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class BillingInformation
    {
        [DataMember]
        public string Name;
        [DataMember]
        public string Address;
        [DataMember]
        public string City;
        [DataMember]
        public string State;
        [DataMember]
        public string ZipCode;
    }
    public class Item
    {
        [DataMember]
        public string PartNo;
        [DataMember]
        public string Description;
        [DataMember]
        public string UnitPrice;
        [DataMember]
        public string Quantity;
        [DataMember]
        public string TotalCost;
        [DataMember]
        public string Size;
        [DataMember]
        public string Color;
    }
}
