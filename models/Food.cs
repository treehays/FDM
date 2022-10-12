namespace FDM.models
{
    public class Food
    {
        public string FoodName { get; set; }
        public double Price { get; set; }
        public Food(string foodName, double price)
        {
            FoodName = foodName;
            Price = price;
        }
        // ref Number(int)
        
    }
}