namespace MilitaryElite.Contracts.Privates.SpecialisedSoldiers
{
    using System.Collections.Generic;
    using MilitaryElite.Models.Privates.SpecialisedSoldiers;
    public interface IEngineer
    {
        IReadOnlyCollection<Repair> Repairs { get; }
    }

}