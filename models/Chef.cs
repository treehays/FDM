namespace FDM
{
    // the solid principle******    

    public class Chef : User
    {
        public int ChefID { get; set; }
        public Chef(string firstName, string lastName, string email, int pIN, int chefID) : base(firstName, lastName, email, pIN)
        {
            ChefID = chefID;
            

        }
    }
}