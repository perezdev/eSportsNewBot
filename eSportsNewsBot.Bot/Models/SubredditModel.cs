using System;

namespace eSportsNewsBot.Bot.Models
{
    public class SubredditModel
    {
        public Guid SubredditId { get; set; }
        public string Name { get; set; }
        public string Shortcut { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
