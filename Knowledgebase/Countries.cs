namespace Ballerz.Football.Knowledgebase
{
    public class Countries
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string FlagUrl { get; set; }
        public int ContinentId { get; set; }
        public virtual Continents Continents { get; set; }
    }
}