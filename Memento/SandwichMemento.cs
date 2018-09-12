using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Component;

namespace Patterns.Memento
{
    public class SandwichMemento
    {
        public Sandwich sandwich { get; set; }
        public string GetDescription() {
            return sandwich.GetDescription();
        }


        public double GetPrize()
        {
            return sandwich.GetPrize();
        }

    }
    class ProspectMemory

    {
        private SandwichMemento _memento;

        // Property

        public SandwichMemento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
