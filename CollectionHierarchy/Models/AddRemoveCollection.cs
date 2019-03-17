using System;
using System.Collections.Generic;
using System.Text;
using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    class AddRemoveCollection : BaseCollection,IRemove
    {

        public AddRemoveCollection()
        :base()
        {
        }
        public override int Add(string item)
        {
            this.List.Insert(0, item);
            return 0;
        }

        public virtual string Remove()
        {
            string element = this.List[this.List.Count - 1];
            this.List.RemoveAt(this.List.Count - 1);
            return element;
        }
    }
}
