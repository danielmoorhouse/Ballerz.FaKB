using System;
using Ballerz.Football.Data;

namespace Ballerz.Football.Forums.Models
{
    public class PostReply
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public string ReplyAuthorImage { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Post Post { get; set; }        
    }
}