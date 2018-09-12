using Patterns.Entities;
using Patterns.Proxy;
using System;
using System.Linq;

namespace Patterns.Facade
{
    public class Facades
    {
        private readonly ProxyOrderRepository repository;

        public Facades()
        {
            repository = new ProxyOrderRepository();
        }

        public void ShowOrder(int OrderId)
        {
            
            try
            {
                Order order = repository.GetOrder(OrderId);
                Console.WriteLine("Order Id: {0}", order.Id);
                Console.WriteLine("Date: {0}", order.OrderDate);
                Console.WriteLine("Customer: {0}, {1}", order.Customer.LastName, order.Customer.FirstName);
                Console.WriteLine("# of items: {0}", order.Details.Count());
                double Price = 0;
                foreach (OrderDetail o in order.Details)
                {
                    Console.WriteLine(o.Description());
                    Price += o.Price();
                }
                Console.WriteLine("for: {0}", Price);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("You got wrong OrderId");
            }
            

            
        }
    }
}
