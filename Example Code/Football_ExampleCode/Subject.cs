using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_ExampleCode
{
    internal class Subject
    {

        private int value { get; } = 1;

        public int amountOfGoals { get; set; } = 0;

        public string name { get; set; }

        public string position { get; set; }

        public List<ConcreteObserver> Observers = new List<ConcreteObserver>();

        public void Attach(ConcreteObserver observer) 
        { 
            Observers.Add(observer);
        }

        public void Detach(ConcreteObserver observer) 
        { 
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (ConcreteObserver observer in Observers)
            {
                observer.Update(value);
            }
        }

        public void GoalSchiessen() 
        {
            amountOfGoals = amountOfGoals + 1;
            Notify();
        }

        public Subject(string name, string position) 
        { 
            this.name = name;
            this.position = position;
        }

    }
}
