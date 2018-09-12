using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Component;
using Patterns.Decorator;

namespace Patterns.ConcreteDecorators
{
    public class Cheese:SandwichDecorator
    {
        public Cheese(Sandwich sandwich) : base(sandwich)
        {
            Description = "Cheese";
            sandwich.Price += 1.35;
        }

        public override string GetDescription()
        {
            return Sandwich.GetDescription()+", "+Description;
        }

        public override double GetPrize()
        {
            return Sandwich.GetPrize();
        }
    }
}
