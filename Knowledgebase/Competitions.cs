namespace Ballerz.Football.Knowledgebase
{
    public class Competitions
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public virtual Countries Countries { get; set; }
        public int CompTypeId { get; set; }
        public virtual CompType CompType { get; set; }
        public string CompName { get; set; }
        public string CompImgUrl { get; set; }
    }
}