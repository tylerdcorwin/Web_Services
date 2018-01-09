using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MathExcptClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MathException.MathExceptionClient proxy = new MathException.MathExceptionClient("BasicHttpBinding_IMathException");
            try
            {
                Console.WriteLine(proxy.DivisionExample(4, 0));
            }
            catch (FaultException<DivideByZeroException> ex)
            {
                Console.WriteLine("Divide By Zero Excepteiron code  " + ex.Detail.Source + " - " + ex.Code + " - " + ex.Reason); //A or 0
            }
            try
            { 
                Console.WriteLine(proxy.FormattingError("a")); //A or 0
            }
            catch (FaultException<FormatException> ex)
            {
                Console.WriteLine("Format Exception code   " + ex.Detail.Source + " - " + ex.Code + " - " + ex.Reason);
            }
                Console.WriteLine("Press enter to finish");
                Console.ReadLine();
            }
            
        }
    }

