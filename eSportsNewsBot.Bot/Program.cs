using eSportsNewsBot.Bot.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSportsNewsBot.Bot
{
    class Program
    {
        public static WebsiteService _websiteService { get; set; } = new WebsiteService();

        private static void Main(string[] args)
        {
            ExecuteCollection();
            ExecutePost();
        }

        private static void ExecuteCollection()
        {
            try
            {
                var websites = _websiteService.GetActiveWebsites();
            }
            catch (Exception ex)
            {

            }
        }

        private static void ExecutePost()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
