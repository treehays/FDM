using FDM.models;
namespace FDM.interfaces
{
    public interface IFoodManager
    {
         public bool ICreateFood(string foodName, double price);
         public void IUpdateFood(string foodName, double price);
         public void IDeleteFood(Food food);
         public void IGetFood(string foodName);//get before deleting and delete
         public void IGetFood(int refNumber);

    }
}