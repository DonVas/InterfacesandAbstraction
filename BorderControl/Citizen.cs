namespace BorderControl
{
    public class Citizen : BasePerson
    {
        private string name;
        private int age;
        public Citizen(string name,int age,  string id) 
            : base(id)
        {
            this.name = name;
            this.age = age;
        }
    }
}
