using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NEITStoreOrdersService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class NEITStoreOrdersService : INEITStoreOrdersService
    {
        public BankAccount GetBankInformation(string AccountID)
        {
            BankAccount myBankAccount = new BankAccount();

            Accounts[] myAccounts = new Accounts[2];
            Accounts myNewAccount1 = new Accounts();
            Accounts myNewAccount2 = new Accounts();

            Options myNewOption1 = new Options();
            Options myNewOption2 = new Options();

            //create primary id/name
            myBankAccount.accountID = "12345";
            myBankAccount.accountName = "Sam Spade";
            
            //create account1 type
            myNewAccount1.accountType = "checking";

            //set account1 options
            myNewOption1.FreeChecking = "N";
            myNewOption1.OverDraftProtection = "Y";            
            myNewAccount1.options = myNewOption1;

            //create account2 type
            myNewAccount2.accountType = "savings";
            
            //set account2 options
            myNewOption2.FreeChecking = "";
            myNewOption2.OverDraftProtection = "N";
            myNewAccount2.options = myNewOption2;

            //add accounts
            myAccounts[0] = myNewAccount1;
            myAccounts[1] = myNewAccount2;
            
            myBankAccount.account = myAccounts;

            return myBankAccount;
        }

        public float ReturnAmountEarned(float balance, float interest)
        {
            return balance * interest;
        }
    }
}
