namespace ListOfGames.Entities
{
    public class Company
    {
        public string CompanysName { get; set; }

        public Company(){}
        public Company(string companysName)
        {
            CompanysName = companysName;
        }
    }
}