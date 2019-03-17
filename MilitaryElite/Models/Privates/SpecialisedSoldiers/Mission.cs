namespace MilitaryElite.Models.Privates.SpecialisedSoldiers
{
    using System;
    using MilitaryElite.Contracts.Privates.SpecialisedSoldiers;
    public class Mission :IMission
    {
        private string codeName;
        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; private set; }

        public string State
        {
            get => this.state;
            set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    throw  new ArgumentException("Invalid state!");
                }

                this.state = value;
            }
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
