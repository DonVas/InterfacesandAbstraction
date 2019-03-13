using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace BorderControl
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var all = new List<IRebellable>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split();

                if (tokens.Length == 3)
                {
                    all.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
                else if (tokens.Length == 2)
                {
                    all.Add(new Robot(tokens[0], tokens[1]));
                }
            }

            var lastDigits = Console.ReadLine();

            all.Where(x=>x.Id.EndsWith(lastDigits))
                .ToList()
                .ForEach(x=>Console.WriteLine(x.Id));
        }
    }
}
