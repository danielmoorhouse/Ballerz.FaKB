using System.Collections.Generic;
using Ballerz.Football.Data;
using Ballerz.Football.Models.Clubs;
using Ballerz.Football.Models.Post;
using Ballerz.Football.Models.Profile;

namespace Ballerz.Football.Models.Home
{
    public class HomeIndexModel
    {
      public string SearchQuery { get; set; }
        public IEnumerable<PostListingModel> LatestPosts { get; set; }
        public IEnumerable<ApplicationUser> Users { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public IEnumerable<ProfileListingModel> Profile { get; set; }
        public IEnumerable<ClubListingModel> Teams { get; set; }
        public IEnumerable<ClubListingModel> Attendance { get; set; }
        public string CountryFlag { get; set; }
        public string Location { get; set; }
        public string MemberSince { get; set; }
    }
}