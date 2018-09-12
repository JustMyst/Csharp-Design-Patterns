using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Entities;
using Patterns.SubjectBase;
using Patterns.Component;
using Patterns.ConcreteComponents;
using Patterns.ConcreteDecorators;
using Patterns.Builders;
using Patterns.Iterator;

namespace Patterns.RealSubject
{
    public class RealOrderRepository:OrderRepositoryBase
    {
        private List<Order> _orders = new List<Order>
                                          {
                                              new Order(){Id=1, OrderDate = new DateTime(2012,7,17)},
                                              new Order(){Id=2, OrderDate = new DateTime(2012,6,16)}
                                          };


        private List<OrderDetail> _orderDetails = new List<OrderDetail>
                                                      {
                                                          new OrderDetail(){MySandwich = new VeggieSandwich(),Id = 1,OrderId = 1},
                                                          new OrderDetail(){MySandwich = new VeggieCornBuilder().GiveSandwich(),Id = 2,OrderId = 1},
                                                          new OrderDetail(){MySandwich = new CheeseTunaBuilder().GiveSandwich(),Id = 3,OrderId = 2}
                                                      };

        private List<Customer> _customers = new List<Customer>()
                                                {
                                                    new Customer(){FirstName = "John",LastName = "Doe",Id=1},
                                                    new Customer(){FirstName = "Jane",LastName = "Doe",Id=2}
                                                };

        private Dictionary<int, int> _orderCustomers = new Dictionary<int, int>();

        

        public RealOrderRepository()
        {
            _orderCustomers.Add(1, 1);
            _orderCustomers.Add(2, 2);
        }


        public override Order GetOrder(int id)
        {

            var order = (from o in _orders where o.Id == id select o).SingleOrDefault();
            return order;
        }
        public override void GetAllOrders()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            for (int j = 0; j < _orders.Count; j++)
            {
                a[j] = _orders[j];
            }
            ConcreteIterator i = a.CreateIterator();
            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
        }
        public override IEnumerable<OrderDetail> GetOrderDetails(int orderId)
        {
            var orderDetails = 
                from o in _orderDetails 
                where o.OrderId == orderId 
                select o;
            return orderDetails;
        }

        public override Customer GetOrderCustomer(int orderId)
        {
            int cutomerId = _orderCustomers[orderId];
            var customer = (from c in _customers where c.Id == cutomerId select c).SingleOrDefault();
            return new Customer(customer);
        }
    }
}
