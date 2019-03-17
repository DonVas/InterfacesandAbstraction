namespace FoodShortage
{
    class Citizen:Human
    {
        private string id;
        private string birthdate;
        private int food;
       
        public Citizen(string name, int age,string id,string birthdate) 
            : base(name, age)
        {
            this.id = id;
            this.birthdate = birthdate;
        }

        public override int Food()
        {
            return this.food;
        }

        public override void BuyFood()
        {
            this.food += 10;
        }
    }
}
