namespace FDM
{
    // the solid principle******    

    public class Chef : User
    {
        public string ChefID { get; set; }
        public string ChefEmploymentDate { get; set; }
        public Chef(string firstName, string lastName, string email, string pIN, string chefID, string chefEmploymentDate) : base(firstName, lastName, email, pIN)
        {
            chefID = chefID;
            ChefEmploymentDate =chefEmploymentDate;
            

        }
    }
}