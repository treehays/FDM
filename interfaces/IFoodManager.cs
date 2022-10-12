using FDM.models;
namespace FDM.interfaces
{
    public interface IFoodManager
    {
         public void CreateFood(string foodName, double price);
         public void UpdateFood(string foodName, string newFoodName, double price, double newPrice);
         public void DeleteFood(int refNumber); //deleting whole instance of food object
         public Food GetFood(string foodNam);//get before deleting and delete
         public Food GetFood(int refNumber);

    }
}