namespace ExplicitInterfaces
{
    using System;
    using Interfaces;

    public class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            while (command != "End")
            {             
                var tokens = command
                    .Split();

                var citizen = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));

                Console.WriteLine(citizen.GetName());
                Console.WriteLine(((IResident)citizen).GetName());
                command = Console.ReadLine();
            }
        }
    }
}
