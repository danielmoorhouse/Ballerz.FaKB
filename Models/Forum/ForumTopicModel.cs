using System.Collections.Generic;
using Ballerz.Football.Models.Post;

namespace Ballerz.Football.Models.Forum
{
    public class ForumTopicModel
    {
        public ForumListingModel Forum { get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; }
        public string SearchQuery { get; set; }        
    }
}