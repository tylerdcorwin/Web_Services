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
            Orderz.OrderServiceClient myProxy = new Orderz.OrderServiceClient();
            string name, address, city, state, zip;
            string[] orderInfo;
            int orderNum, itemNum;
            double totalCost;


            name = myProxy.GetBillinAddressForAnOrder(1).Name;
            address = myProxy.GetBillinAddressForAnOrder(1).Address;
            city = myProxy.GetBillinAddressForAnOrder(1).City;
            state = myProxy.GetBillinAddressForAnOrder(1).State;
            zip = myProxy.GetBillinAddressForAnOrder(1).ZipCode;

            orderNum = myProxy.GetNumberOfOrders();
            totalCost = myProxy.GetTotalCostForAnOrder(1);
            itemNum = myProxy.HowManyOrderedForAPartNo("JETSWEATER");
            

            Console.WriteLine("Billing Information for Order 1");
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Address = " + address);
            Console.WriteLine("City = " + city);
            Console.WriteLine("State = " + state);
            Console.WriteLine("ZipCode = " + zip);
            Console.WriteLine("Number of Orders = " + orderNum);
            Console.WriteLine("Total cost for order 1 = " + totalCost);
            Console.WriteLine("The number of orders with part 'JETSWEATER' = " + itemNum);
            Console.WriteLine("Items in order 1 (Qty, Part, Description) ");

            ConsoleApplication1.Orderz.Item[] items = myProxy.GetItemListForOrder(1);
            int number = items.Length;
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("PartNo: " + items[i].PartNo);
                Console.WriteLine("Description: " + items[i].Description);
                Console.WriteLine("Quantity: " + items[i].Quantity);                                                           
             }                
            Console.ReadLine();
        }
    }
}
