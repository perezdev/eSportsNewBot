using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSportsNewsBot.Bot.Models
{
    public class GameModel
    {
        public Guid GameId { get; set; }
        public string Name { get; set; }
        public string CssClass { get; set; }
    }
}
