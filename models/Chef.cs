namespace FDM
{
    // the solid principle******    

    public class Chef : User
    {
        public string ChefID { get; set; }
        public Chef(string firstName, string lastName, string email, int pIN, string chefID) : base(firstName, lastName, email, pIN)
        {
            ChefID = chefID;
            

        }
    }
}