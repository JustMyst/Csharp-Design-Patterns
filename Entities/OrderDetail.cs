using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Component;

namespace Patterns.Entities
{
    public class OrderDetail
    {
        public Sandwich MySandwich { get; set; }
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Description()
        {
            return MySandwich.GetDescription();
        }
        public double Price()
        {
            return MySandwich.GetPrize();
        }

    }
}
