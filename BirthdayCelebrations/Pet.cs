using System;

namespace BirthdayCelebrations
{
    public class Pet : IBirthable, IName
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/MM/yyyy", null);
        }
           
        public string Name { get; private set; }

        public DateTime Birthdate { get; }
    }
}
