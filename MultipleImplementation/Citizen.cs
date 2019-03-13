using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson,IBirthable,IIdentifiable
    {
        private string name;
        private int age;
        private string birthdate;
        private string id;

      
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Birthdate
        {
            get => birthdate;
            set => birthdate = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
    }
}
