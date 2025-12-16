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

            Subject Manchester_United = new Subject("Bruno Fernandes", "Stürmer");

            Console.WriteLine("Familienmitglieder, welche kommen, werden aufgeschrieben");
            Manchester_United.Attach(Manuell);
            Manchester_United.Attach(Simona);
            Manchester_United.Attach(Jonas);

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Benachrichtige Goals (Vor Spiel)");
            foreach (ConcreteObserver Person in Manchester_United.Observers)
                Console.WriteLine($"{Person.rolle} {Person.name}: {Person.amountOfGoals}");
            Console.WriteLine("--------------------------");


            Console.WriteLine("\nJonas kommt doch nicht mit");
            Console.WriteLine("\nJonas wird aus Liste entfernt");
            Manchester_United.Detach(Jonas);

            Console.WriteLine($"\n{Manchester_United.name} hat ein Goal geschossen");
            Manchester_United.GoalSchiessen();
            Console.WriteLine($"Anzahl Tore: {Manchester_United.amountOfGoals}");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Benachrichtige Goals (Während Spiel)");
            foreach (ConcreteObserver Person in Manchester_United.Observers)
                Console.WriteLine($"{Person.rolle} {Person.name}: {Person.amountOfGoals}");
            Console.WriteLine("--------------------------");

            Console.WriteLine($"\n{Manchester_United.name} hat ein Goal geschossen");
            Manchester_United.GoalSchiessen();
            Console.WriteLine($"Anzahl Tore: {Manchester_United.amountOfGoals}");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Benachrichtige Goals (Während Spiel)");
            foreach (ConcreteObserver Person in Manchester_United.Observers)
                Console.WriteLine($"{Person.rolle} {Person.name}: {Person.amountOfGoals}");
            Console.WriteLine("--------------------------");

        }
    }
}
