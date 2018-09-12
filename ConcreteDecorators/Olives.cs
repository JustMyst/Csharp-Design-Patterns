using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Component;
using Patterns.Decorator;

namespace Patterns.ConcreteDecorators
{
    public class Olives : SandwichDecorator
    {
        public Olives(Sandwich sandwich)
            : base(sandwich)
        {
            Description = "Olives";
            sandwich.Price += 0.89;

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
