using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Component;
using Patterns.Memento;
using Patterns.Observer;

namespace Patterns.ConcreteComponents
{
    public class TunaSandwich : Sandwich
    {
        public double Prize = 4.10;

        public new double Price
        {

            get { return Prize; }
            set

            {
                if (Prize != value)
                {
                    Prize = value;
                    Notify();
                }
            }
        }
        public TunaSandwich()
        {
            Description = "Tuna Sandwich";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrize()
        {
            return Prize;
        }
        public override SandwichMemento SaveMemento()
        {
            return new SandwichMemento() { sandwich = this };
        }

        // Restores memento

        public override void RestoreMemento(SandwichMemento memento)
        {
            this.Description = memento.GetDescription();
            this.Prize = memento.GetPrize();
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
                o.Update(this);
            }
        }
    }
}
