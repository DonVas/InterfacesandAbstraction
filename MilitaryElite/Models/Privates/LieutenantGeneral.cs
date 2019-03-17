using System.Linq;

namespace MilitaryElite.Models.Privates
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using MilitaryElite.Contracts.Privates;

    public class LieutenantGeneral : Private, ILieutenantGeneral 
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, IList<Private> privates) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new ReadOnlyCollection<Private>(privates);
        }

        public ReadOnlyCollection<Private> Privates { get; private set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (var @private in Privates.OrderBy(x=>x.FirstName))
            {
                stringBuilder.AppendLine("  "+ @private.ToString());
            }
               
            return stringBuilder.ToString().TrimEnd();
        }
    }
}