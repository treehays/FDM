namespace FDM.interfaces
{
    public interface IOrderManager
    {
        public bool ICreateFood();
         public void IUpdateFood();
         public void IDeleteFood(); //deleting whole instance of food object
         public void IGetFood();
         
    }
}