using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Component;
using Patterns.Decorator;

namespace Patterns.ConcreteDecorators
{
    public class Corn : SandwichDecorator
    {
        public Corn(Sandwich sandwich)
            : base(sandwich)
        {
            sandwich.Price += 0.35;
            Description = "Corn";
        }

        public override string GetDescription()
        {
            return Sandwich.GetDescription()+", "+Description;
        }

    }
}
