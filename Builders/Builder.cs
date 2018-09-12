using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Entities;
using Patterns.SubjectBase;
using Patterns.Component;
using Patterns.ConcreteComponents;
using Patterns.ConcreteDecorators;
using Patterns.Memento;
using Patterns.Observer;

namespace Patterns.Builders
{
    public class VeggieCornBuilder
    {
        protected Sandwich sandwich = new VeggieSandwich();

        public void addDecorator()
        {
            sandwich.Attach(new ConcreteObserver(sandwich, "observ"));
            SandwichMemento mem = sandwich.SaveMemento();
            new Corn(sandwich);
        }
        public Sandwich GiveSandwich() {
            return sandwich;
        }

    }
    public class CheeseTunaBuilder
    {
        private Sandwich sandwich = new TunaSandwich();
        public void addDecorator()
        {
            sandwich.Attach(new ConcreteObserver(sandwich, "observ"));

            SandwichMemento mem = sandwich.SaveMemento();

            new Cheese(sandwich);
        }
        public Sandwich GiveSandwich()
        {
            return sandwich;
        }

    }
}
