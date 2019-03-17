namespace FoodShortage
{
    using System;
    public abstract class Human : IBuyer
    {
        private string name;
        private int age;

        protected Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private int Age
        {
            get => age;
            set => age = value;
        }


        public  string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value) && string.IsNullOrWhiteSpace(value))
                {
                    throw new AggregateException("Name is not Valid!");
                }

                this.name = value;
            }
        }

        public abstract int Food();

        public abstract void BuyFood();
    }
}
