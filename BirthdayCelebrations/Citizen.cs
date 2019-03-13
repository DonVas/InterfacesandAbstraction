using System;

namespace BirthdayCelebrations
{
    public class Citizen : IBirthable, IRebellable, IName
    {
        private int age;

        public Citizen(string name, int age, string id, string birthdate) 
            {
            this.Name = name;
            this.age = age;
            this.Id = id;
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/MM/yyyy", null);
        }
        public string Id { get; private set; }
        public DateTime Birthdate { get; private set; }
        public string Name { get; private set; }
    }
}
