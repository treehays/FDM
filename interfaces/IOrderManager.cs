namespace FDM.interfaces
{
    public interface IOrderManager
    {
        public void CreateOrder(int orderId, string orderStatus);
         public void UpdateOrder(string orderStatus);
         public void DeleteOrder(int orderId); 
         //deleting whole instance of food object
         public Order GetOrder(string orderId);
    }
}