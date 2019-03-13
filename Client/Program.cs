using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.CounterServices;
 
namespace Client
{
  public  class Program
    {
        static void Main(string[] args)
        {
            // sad撒多fdsfds sdas
             CalculatorServiceClient client = new  CalculatorServiceClient();
            Console.Write(client.Add(1,2));
            Console.ReadKey();
        }
    }
}
