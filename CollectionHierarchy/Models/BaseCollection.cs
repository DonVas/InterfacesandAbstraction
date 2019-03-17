using System;
using System.Collections.Generic;
using System.Text;
using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public abstract class BaseCollection:IAdd
    {
        private List<string> elements;

        protected BaseCollection()
        {
            this.elements= new List<string>();
        }
        protected IList<string> List => this.elements;

        public abstract int Add(string item);

    }
}
