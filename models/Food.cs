namespace FDM.models
{
    public class Food
    {
        public string FoodName { get; set; }
        public double price { get; set; }
        public Food(string foodName, double price)
        {
            FoodName = foodName;
            price = price;
        }
        // ref Number(int)
        
    }
}