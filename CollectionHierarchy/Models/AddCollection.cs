using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class AddCollection:BaseCollection
    {
        public AddCollection()
            : base()
        {
        }

        public override int Add(string element)
        {
            base.List.Add(element);

            return this.List.Count - 1;
        }
    }
}
