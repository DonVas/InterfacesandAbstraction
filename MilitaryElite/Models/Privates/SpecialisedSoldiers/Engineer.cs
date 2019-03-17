namespace MilitaryElite.Models.Privates.SpecialisedSoldiers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MilitaryElite.Contracts.Privates.SpecialisedSoldiers;

    public class Engineer : SpecialisedSoldier , IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary,string corps,IReadOnlyCollection<Repair> repairs)
            : base(id, firstName, lastName, salary,corps)
        {
            this.Repairs = repairs;
        }

        public IReadOnlyCollection<Repair> Repairs { get; private set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString())
                .AppendLine($"Repairs:");
            foreach (var repair in Repairs)
            {
                stringBuilder.AppendLine("  " + repair.ToString());
            }
               
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
