namespace FoodShortage
{
    class Rebel:Human
    {
        private string group;
        private int food;
    
        public Rebel(string name, int age,string group) 
            : base(name, age)
        {
            this.@group = @group;
        }

        public override int Food()
        {
            return this.food;
        }

        public override void BuyFood()
        {
            this.food += 5;
        }
    }
}
