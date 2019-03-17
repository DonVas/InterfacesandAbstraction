namespace MilitaryElite.Models.Privates
{
    using System;
    using System.Text;
    using MilitaryElite.Contracts.Privates;
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary,string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get => this.corps;
            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException("Invalid Corps!");
                }

                this.corps = value;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString())
                .Append($"Corps: {this.Corps}");
            return stringBuilder.ToString();
        }
    }
}
