using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Component;
using Patterns.Memento;
using Patterns.Observer;

namespace Patterns.Decorator
{
    public class SandwichDecorator : Sandwich
    {
        protected Sandwich Sandwich;

        public SandwichDecorator(Sandwich sandwich)
        {
            Sandwich = sandwich;
        }

        public override string GetDescription()
        {
            return Sandwich.GetDescription();
        }

        public override double GetPrize()
        {
            return Sandwich.GetPrize();
        }

        public override void RestoreMemento(SandwichMemento memento)
        {
            this.Description = memento.GetDescription();
        }

        public override SandwichMemento SaveMemento()
        {
            return new SandwichMemento() { sandwich = this };
        }
        private List<ConcreteObserver> _observers = new List<ConcreteObserver>();

        public override void Attach(ConcreteObserver observer)
        {
            _observers.Add(observer);
        }

        public override void Detach(ConcreteObserver observer)
        {
            _observers.Remove(observer);
        }

        public override void Notify()
        {
            foreach (ConcreteObserver o in _observers)
            {
                o.Update();
            }
        }
    }
}
