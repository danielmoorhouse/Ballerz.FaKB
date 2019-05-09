namespace Ballerz.Football.Knowledgebase
{
    public class StadiumImages
    {
        public int Id { get; set; }
        public int StadiumId { get; set; }
        public virtual Stadium Stadium { get; set; }
        public string StadiumImageUrl { get; set; }
        public string ImageCaption { get; set; }
    }
}