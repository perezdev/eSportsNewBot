using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSportsNewsBot.Bot.Models
{
    public class WebsiteModel
    {
        public Guid WebsiteId { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public GameModel Game { get; set; }
    }
}
