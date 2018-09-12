using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Entities;
using Patterns.Proxy;
using Patterns.Facade;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Facades fasada = new Facades();
            while (true)
            {
                Console.WriteLine("Chose orderId to show full order (1-2)");
                int OrderId = 0;
                if (int.TryParse(Console.ReadLine(), out OrderId))
                {
                    fasada.ShowOrder(OrderId);
                }
                else { break; }
            }
        }
    }
}
