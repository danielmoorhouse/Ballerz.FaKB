namespace Ballerz.Football.Models.Countries
{
    public class CountryListingModel
    {
          public int Id { get; set; }
        public string Name { get; set; }
        public string FlagUrl { get; set; }
        public int ContinentId { get; set; }
        public string ContinentName { get; set;  }
    }
}