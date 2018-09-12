using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Component;

namespace Patterns.Observer
{

    public abstract class Observer

    {
        public abstract void Update(Sandwich sandwich);
    }

    public class ConcreteObserver : Observer

    {
        private string _name;
        private string _observerState;
        private Sandwich _sandwich;

        // Constructor

        public ConcreteObserver(
          Sandwich sandwich, string name)
        {
            this._sandwich = sandwich;
            this._name = name;
        }

        public override void Update(Sandwich sandwich)
        {
            _sandwich = sandwich;
            _observerState = _sandwich.GetDescription();
            Console.WriteLine("Observer {0}'s new state is {1}",
              _name, _observerState);
        }

        // Gets or sets subject

        public Sandwich sandwich
        {
            get { return _sandwich; }
            set { _sandwich = value; }
        }
    }
}
