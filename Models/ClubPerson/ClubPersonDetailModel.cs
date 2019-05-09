using System.Collections.Generic;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Models.ClubPerson
{
    public class ClubPersonDetailModel
    {
        public Knowledgebase.ClubPerson ClubPerson { get; set; }
        public Club Club { get; set; }
        public ClubRole ClubRole { get; set; }
        public Knowledgebase.Competitions Competition { get; set; }
        public Knowledgebase.Countries Country { get; set; }

        public IEnumerable<Knowledgebase.ClubPersonHistory> ClubPersonHistory { get; set; }
    }
}