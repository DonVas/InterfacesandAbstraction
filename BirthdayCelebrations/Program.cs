namespace BirthdayCelebrations
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    public class Program
    {
        public static void Main()
        {
            var all = new List<IBirthable>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split();

                if (tokens[0]== "Citizen")
                {
                    all.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3],tokens[4]));
                }
                else if (tokens[0] == "Pet")
                {
                    all.Add(new Pet(tokens[1], tokens[2]));
                }
            }

            var lastDigits = int.Parse(Console.ReadLine());

            all.Where(x => x.Birthdate.Year == lastDigits)
                .ToList()
                .ForEach(x=>Console.WriteLine($"{x.Birthdate:dd/MM/yyyy}"));
        }
    }
}
