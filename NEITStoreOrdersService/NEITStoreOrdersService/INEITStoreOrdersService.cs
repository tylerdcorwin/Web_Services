using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NEITStoreOrdersService
{
    [ServiceContract]
    public interface INEITStoreOrdersService
    {

        [OperationContract]
        float ReturnAmountEarned(float balance, float interest);

        [OperationContract]
        BankAccount GetBankInformation(string AccountID);
    }

    [DataContract]
    public class BankAccount
    {
        [DataMember]
        public string accountID;
        [DataMember]
        public string accountName;
        [DataMember]
        public Accounts[] account;
    }

    [DataContract]
    public class Accounts
    {
        [DataMember]
        public string accountType;
        [DataMember]
        public Options options;
    }

    [DataContract]
    public class Options
    {
        [DataMember]
        public string FreeChecking;
        [DataMember]
        public string OverDraftProtection;

    }
}
