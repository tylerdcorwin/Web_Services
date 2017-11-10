using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateClient
{
    class Program
    {
        static void Main(string[] args)
        {
            StateService.StateExampleClient proxy = new StateService.StateExampleClient("WSHttpBinding_IStateExample");

            //proxy.Open();
            proxy.Initialize(5);
            int a, b;
            a = 5;
            b = 6;
            Console.WriteLine("original value a : {0} and b : {1}", a, b);


            int result;
            result = proxy.Add(a, b);

            Console.WriteLine("add result : {0}", result);
            result = proxy.Add(a, b);
            Console.WriteLine("add result : {0}", result);
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
