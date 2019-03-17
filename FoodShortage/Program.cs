using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FoodShortage
{
    public class Program
    {
        public static void Main()
        {

            var peopleBuyers = new List<IBuyer>(); 

            var numberOfHumans = int.Parse(Console.ReadLine());
            var humanArg = Console.ReadLine();

            for (int i = 0; i < numberOfHumans; i++)
            {
                var arguments = humanArg
                    .Split();
                if (arguments.Length == 3)
                {
                    peopleBuyers.Add(new Rebel(arguments[0],int.Parse(arguments[1]),arguments[2]));
                }
                else if(arguments.Length == 4)
                {
                    peopleBuyers.Add(new Citizen(arguments[0],int.Parse(arguments[1]),arguments[2],arguments[3]));
                }

                humanArg = Console.ReadLine();
            }

            while (humanArg != "End")
            {
                var buyer = peopleBuyers.SingleOrDefault(b => b.Name == humanArg);

                buyer?.BuyFood();
                humanArg = Console.ReadLine();
            }

            Console.WriteLine(peopleBuyers.Sum(x=>x.Food()));
        }
    }
}
