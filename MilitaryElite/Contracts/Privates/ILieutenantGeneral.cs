namespace MilitaryElite.Contracts.Privates
{
    using System.Collections.ObjectModel;
    using Models;

    public interface ILieutenantGeneral
    {
        ReadOnlyCollection<Private> Privates { get; }
    }
}