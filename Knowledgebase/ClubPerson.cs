using System;
using Microsoft.AspNetCore.Http;

namespace Ballerz.Football.Knowledgebase
{
    public class ClubPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime  DoB { get; set; }
        public string From { get; set; }
        public string PlayerImageUrl { get; set; }
        public string Value { get; set; }
        public string IsCaptain { get; set;  }
        public int CountryId { get; set; }
        public virtual Countries Countries { get; set; }
        public int ClubId { get; set; }
        public virtual Club Club { get; set; }
        public int ClubRoleId { get; set;  }
        public virtual ClubRole ClubRole { get; set; }
    }
}