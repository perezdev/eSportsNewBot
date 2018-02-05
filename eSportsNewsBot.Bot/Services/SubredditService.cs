using eSportsNewsBot.Bot.Models;
using eSportsNewsBot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSportsNewsBot.Bot.Services
{
    public class SubredditService
    {
        public List<SubredditModel> GetActiveSubreddits()
        {
            var subreddits = new List<SubredditModel>();

            using (ESportsNewsContext context = new ESportsNewsContext())
            {
                subreddits = (from s in context.Subreddits
                              where s.Active
                              select new SubredditModel()
                              {
                                  SubredditId = s.SubredditID,
                                  Name = s.Name,
                                  Shortcut = s.Shortcut,
                                  Active = s.Active,
                                  CreatedDate = s.CreatedDate,
                              }).ToList();
            }

            return subreddits;
        }
    }
}
