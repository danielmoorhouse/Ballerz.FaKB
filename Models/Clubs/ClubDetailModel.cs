using System.Collections.Generic;

namespace Ballerz.Football.Models.Clubs
{
    public class ClubDetailModel
    {
     public Knowledgebase.Club Clubs { get; set; }
     public Knowledgebase.Stadium Stadiums { get; set; }
     public IEnumerable<Models.ClubPerson.ClubPersonListingModel> ClubPeople { get; set; }
     public Knowledgebase.Competitions Competitions { get; set; }
    
     
    }
}