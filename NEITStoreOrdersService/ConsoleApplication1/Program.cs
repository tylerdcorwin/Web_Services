using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.NEITStoreOrdersServiceClient myProxy = new ServiceReference1.NEITStoreOrdersServiceClient();

            Console.WriteLine("----- Bank Information ------");

            Console.WriteLine("Bank Account ID: " + myProxy.GetBankInformation("12345").accountID);
            Console.WriteLine("Bank Account name: " + myProxy.GetBankInformation("12345").accountName);
            Console.WriteLine("Account Type: " + myProxy.GetBankInformation("12345").account[0].accountType);
            Console.WriteLine("Free Checking: " + myProxy.GetBankInformation("12345").account[0].options.FreeChecking);
            Console.WriteLine("Overdraft Protection: " + myProxy.GetBankInformation("12345").account[0].options.OverDraftProtection);

            Console.WriteLine();
            Console.WriteLine("Hit ENTER to exit");
            Console.ReadLine();
        }
    }
}
