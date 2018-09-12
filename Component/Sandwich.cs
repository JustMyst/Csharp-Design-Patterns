using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Memento;
using Patterns.Observer;

namespace Patterns.Component
{
    public abstract class Sandwich
    {
        public double Price;

        public abstract string GetDescription();

        public abstract double GetPrize();

        public string Description { get; set; }

        public abstract SandwichMemento SaveMemento();
        public abstract void RestoreMemento(SandwichMemento memento);

        public abstract void Attach(ConcreteObserver observer);
        public abstract void Detach(ConcreteObserver observer);
        public abstract void Notify();


    }
}
