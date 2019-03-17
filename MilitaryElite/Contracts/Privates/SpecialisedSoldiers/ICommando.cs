namespace MilitaryElite.Contracts.Privates.SpecialisedSoldiers
{
    using System.Collections.Generic;
    using MilitaryElite.Models.Privates.SpecialisedSoldiers;
    public interface ICommando
    {
        IReadOnlyCollection<Mission> Missions { get; }
        void CompleteMission(string codeName);
    }
}