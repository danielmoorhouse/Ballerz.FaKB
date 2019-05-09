using System;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Data
{
    public class Profile
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string FirstName { get;set;}
        public string LastName { get; set; }
        public int ClubId { get; set; }
        public virtual Club Club { get; set; }
        public DateTime MemberSince { get; set; }
        public string ShortDescription { get; set; }
        
        public int CountryId { get; set; }
        public virtual Countries Countries { get; set; }
        public string ProfileImageUrl { get; set; }

        public string Location { get; set; }
        
        public bool IsAdmin { get; set; }

    }
}