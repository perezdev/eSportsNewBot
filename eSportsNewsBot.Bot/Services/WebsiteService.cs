using eSportsNewsBot.Bot.Models;
using eSportsNewsBot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSportsNewsBot.Bot.Services
{
    public class WebsiteService
    {
        public List<WebsiteModel> GetActiveWebsites()
        {
            var websites = new List<WebsiteModel>();

            using (ESportsNewsContext context = new ESportsNewsContext())
            {
                websites = (from w in context.Websites
                            join g in context.Games on w.GameID equals g.GameID
                            select new WebsiteModel()
                            {
                                WebsiteId = w.WebsiteID,
                                Title = w.Title,
                                URL = w.URL,
                                Active = w.Active,
                                CreatedDate = w.CreatedDate,
                                Game = new GameModel()
                                {
                                    GameId = g.GameID,
                                    Name = g.Name,
                                    CssClass = g.CssClass
                                }
                            }).ToList();
            }

            return websites;
        }
    }
}
