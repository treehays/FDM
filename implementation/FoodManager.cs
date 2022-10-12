using FDM.interfaces;
using FDM.models;

namespace FDM.implementation
{
    public class FoodManager : IFoodManager
    {
        public static List<Food> listOfFoods = new List<Food>(); //Temporary DatBase or innmemory
        public void CreateFood(string foodName, double price)
        {
            Random random = new Random(); //generate Radome food refrence ID from 100 to 999(3digit)
            int refNumber = random.Next(100, 999);

            Food food = new Food(refNumber, foodName, price); // creating instance of food
            System.Console.WriteLine($"{food} Created successfully.");
        }

        public void DeleteFood(int refNumber)
        {
            foreach (var item in listOfFoods)
            {
                if (item.RefNumber == refNumber)
                {
                    listOfFoods.Remove(item);
                    break;
                }
            }
            System.Console.WriteLine("remove successfully");

        }

        public Food GetFood(string foodName)
        {
            foreach (var item in listOfFoods)
            {
                if (item.FoodName == foodName)
                {
                    return item;
                }
            }
            return null;
        }

        public Food GetFood(int refNumber)
        {
            foreach (var item in listOfFoods)
            {
                if (item.RefNumber == refNumber)
                {
                    return item;

                }
            }
            return null;
        }

        public void UpdateFood(string foodName, string newFoodName, double price, double newPrice)
        {
            Food foodToUpdate = GetFood(foodName);
            foodToUpdate.FoodName = newFoodName;
            foodToUpdate.Price = newPrice;
            Console.WriteLine("Food update Successfully.");


        }
    }
}