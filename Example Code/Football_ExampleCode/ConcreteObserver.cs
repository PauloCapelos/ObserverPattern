using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_ExampleCode
{
    internal class ConcreteObserver : IObserver
    {
        public int amountOfGoals { get; set; } = 0;

        public string name { get; set; }

        public string rolle {  get; set; }

        public void Update(int value) 
        {
            amountOfGoals = amountOfGoals + value;
        }

        public ConcreteObserver (string name, string rolle) 
        { 
            this.name = name;   
            this.rolle = rolle;
        }
    }
}
