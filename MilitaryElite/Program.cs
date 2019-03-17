namespace MilitaryElite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Models.Privates;
    using Models.Privates.SpecialisedSoldiers;

    public class Program
    {
        public static void Main()
        {
            var soldiers=new List<Soldier>();
            var command = Console.ReadLine();

            while (command !="End")
            {
                var soldierArg = command?.Split();
                var soldierType = soldierArg[0];
                var id = soldierArg[1];
                var firstName = soldierArg[2];
                var lastName = soldierArg[3];
               
                if (soldierType== "Private")
                {
                    var salary = decimal.Parse(soldierArg[4]);
                    var @private = new Private(id,firstName,lastName,salary);
                    soldiers.Add(@private);
                }
                else if (soldierType=="Spy")
                {
                    var codeNumber = int.Parse(soldierArg[4]);
                    soldiers.Add(new Spy(id,firstName,lastName,codeNumber));
                }
                else if (soldierType== "LieutenantGeneral")
                {
                    var salary = decimal.Parse(soldierArg[4]);
                    var ids = soldierArg.Skip(5).ToList();
                    var privates = GetPrivates(ids, soldiers);
                    soldiers.Add(new LieutenantGeneral(id,firstName,lastName,salary,privates));
                }
                else if (soldierType=="Engineer")
                {
                    var salary = decimal.Parse(soldierArg[4]);
                    var corps = soldierArg[5];
                    var repairsArg = soldierArg.Skip(6).ToList();
                    var repairers = GetRepairs(repairsArg);
                    try
                    {
                        soldiers.Add(new Engineer(id, firstName, lastName, salary, corps, repairers));
                    }
                    catch (Exception)
                    {
                    }
                    
                }
                else if (soldierType == "Commando")
                {
                    var salary = decimal.Parse(soldierArg[4]);
                    var corps = soldierArg[5];
                    var missionArgs = soldierArg.Skip(6).ToList();
                    var missions = GetMissions(missionArgs);
                    try
                    {
                        soldiers.Add(new Commando(id, firstName, lastName, salary, corps, missions));
                    }
                    catch (Exception)
                    {                   
                    }     
                }
                command = Console.ReadLine();
            }
            soldiers.ForEach(Console.WriteLine);
        }


        private static List<Mission> GetMissions(List<string> missionArgs)
        {
            var missions = new List<Mission>();
            for (int i = 0; i < missionArgs.Count; i += 2)
            {
                var codeName = missionArgs[i];
                var state = missionArgs[i + 1];
                try
                {
                    missions.Add(new Mission(codeName, state));
                }
                catch (Exception)
                {                  
                }                
            }

            return missions;
        }

        private static List<Repair> GetRepairs(List<string> repairsArg)
        {
            var repairs = new List<Repair>();
            for (int i = 0; i < repairsArg.Count; i+=2)
            {
                var partName = repairsArg[i];
                var hoursWorked = int.Parse(repairsArg[i + 1]);
                 repairs.Add(new Repair(partName,hoursWorked));
            }

            return repairs;
        }

        private static List<Private> GetPrivates(List<string> ids, List<Soldier> soldiers)
        {
           var privates= new List<Private>();

           foreach (var soldier in soldiers.Where(x=>x.GetType().Name== nameof(Private)))
           {
               if (ids.Contains(soldier.Id))
               {
                   privates.Add((Private)soldier);
               }
           }

           return privates;
        }
    }
}
