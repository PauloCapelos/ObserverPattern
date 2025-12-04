using System;

namespace Football_ExampleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteObserver Manuell = new ConcreteObserver("Manuell", "Vater");
            ConcreteObserver Simona = new ConcreteObserver("Simona", "Mutter");
            ConcreteObserver Jonas = new ConcreteObserver("Jonas", "Bruder");

            Subject David = new Subject("David", "Stürmer");

            Console.WriteLine("Familienmitglieder, welche kommen, werden aufgeschrieben");
            David.Attach(Manuell);
            David.Attach(Simona);
            David.Attach(Jonas);

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Notierte Goals (Vor Spiel)");
            foreach (ConcreteObserver Person in David.Observers)
                Console.WriteLine($"{Person.rolle} {Person.name}: {Person.amountOfGoals}");
            Console.WriteLine("--------------------------");


            Console.WriteLine("\nJonas kommt doch nicht mit");
            Console.WriteLine("\nJonas wird aus Liste entfernt");
            David.Detach(Jonas);

            Console.WriteLine("\nDavid hat ein Goal geschossen");
            David.GoalSchiessen();
            Console.WriteLine($"Anzahl Tore: {David.amountOfGoals}");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Notierte Goals (Während Spiel)");
            foreach (ConcreteObserver Person in David.Observers)
                Console.WriteLine($"{Person.rolle} {Person.name}: {Person.amountOfGoals}");
            Console.WriteLine("--------------------------");

            Console.WriteLine("\nJonas kommt doch noch");
            Console.WriteLine("\nJonas wird zur Liste hinzugefügt");
            David.Attach(Jonas);

            Console.WriteLine("\nDavid hat ein Goal geschossen");
            David.GoalSchiessen();
            Console.WriteLine($"Anzahl Tore: {David.amountOfGoals}");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Notierte Goals (Während Spiel)");
            foreach (ConcreteObserver Person in David.Observers)
                Console.WriteLine($"{Person.rolle} {Person.name}: {Person.amountOfGoals}");
            Console.WriteLine("--------------------------");
        }
    }
}
