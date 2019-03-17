using System.Dynamic;

namespace FoodShortage
{
    public interface IBuyer
    {
        void BuyFood();
        int Food();
        string Name{get;}
    }
}