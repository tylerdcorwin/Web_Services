using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

//Name of the Project, change to what the service will do/company name
namespace ContactManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IContactManager
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        //all webservice call and methods go here
        //all methods need [OperationContract] in order to be useable as a webservice
        [OperationContract]
        int GetNumberOfContracts();

        [OperationContract]
        ContactInformation GetClientInformation();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //all calls, structures and datamembers go here
    //all variables need [DataMember] attached to them
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
    public class ContactInformation
    {
        [DataMember]
        public string FirstName;
        [DataMember]
        public string LastName;
        [DataMember]
        public string PhoneNumber;
        [DataMember]
        public string FaxNumber;
        [DataMember]
        public string EmailAddress;
                
    }
}
