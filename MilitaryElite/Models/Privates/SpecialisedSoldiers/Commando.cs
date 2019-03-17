namespace MilitaryElite.Models.Privates.SpecialisedSoldiers
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using MilitaryElite.Contracts.Privates.SpecialisedSoldiers;

    public class Commando :SpecialisedSoldier , ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary,string corps,IReadOnlyCollection<Mission> missions)
            : base(id, firstName, lastName, salary,corps)
        {
            this.Missions = missions;
        }

        public IReadOnlyCollection<Mission> Missions { get; }
        public void CompleteMission(string codeName)
        {
            var mission = Missions
                .FirstOrDefault(x => x.CodeName == codeName);

            if (mission != null)
            {
                mission.State = "Complete";
            }
        }

        public override string ToString()
        {
            var stringBuilder= new StringBuilder();
            stringBuilder.AppendLine(base.ToString())
                .AppendLine($"Missions:");
            foreach (var mission in Missions)
            {
                stringBuilder.AppendLine("  " + mission.ToString());
            }
            
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
