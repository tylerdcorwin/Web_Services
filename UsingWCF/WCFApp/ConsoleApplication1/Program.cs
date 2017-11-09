using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel; //added reference!

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //webservice namespace--> new proxy--> create new reference
            ContactExample.ContactManagerClient myProxy = new ContactExample.ContactManagerClient();
            int m;
            m = myProxy.GetNumberOfContracts();
            ContactExample.ContactInformation info = myProxy.GetClientInformation(); //like a json object
            Console.WriteLine("Fax Number: " + info.FaxNumber);
            Console.WriteLine("Number of Contacts: " + m);
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
