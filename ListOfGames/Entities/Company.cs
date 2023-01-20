namespace ListOfGames.Entities
{
    public class Company
    {
        public string CompanysName { get; set; }
        public string HostCountry { get; set; }

        public Company(){}
        
        public Company(string companysName, string hostCountry)
        {
            CompanysName = companysName;
            HostCountry = hostCountry;
        }
    }
}