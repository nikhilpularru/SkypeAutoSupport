namespace Nick.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ChatBot.ChatBotContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ChatBot.ChatBotContext context)
        {   
            SeedAllProblems().ForEach(c => context.Problems.AddOrUpdate(c));
            SeedAllCatagories().ForEach(c => context.Categories.AddOrUpdate(c));
            context.SaveChanges();
        }

        private List<ChatBot.Problem> SeedAllProblems()
        {
            List<ChatBot.Problem> problemList = new List<ChatBot.Problem>
            {
                new ChatBot.Problem { ProblemName ="TFS"   },
                new ChatBot.Problem { ProblemName ="GAFT"  },
                new ChatBot.Problem { ProblemName ="WiFi"  }


            };
            return problemList;
        }

        private List<ChatBot.Category> SeedAllCatagories()
        {
            List<ChatBot.Category> catagoryList = new List<ChatBot.Category>
            {
                new ChatBot.Category { CategoryName ="Admin TFS" },
                new ChatBot.Category { CategoryName ="TFS Merge" },
                new ChatBot.Category { CategoryName ="GAFT KT" },
                new ChatBot.Category { CategoryName ="GAFT Architecture" },
                new ChatBot.Category { CategoryName ="WiFi Trouble" },
                new ChatBot.Category { CategoryName ="Wifi Ticket" }
            };
            return catagoryList;
        }

        private List<ChatBot.Resource> SeedAllResources()
        {
            List<ChatBot.Resource> resourceList = new List<ChatBot.Resource>
            {
                new ChatBot.Resource { ResourceName ="Please use the following link to raise the request: https://dell.service-now.com/esp/" },
                new ChatBot.Resource { ResourceName ="Perform the folowing steps: 1. abc \n 2. abc \n 3. abc \n 3. abc" },
                new ChatBot.Resource { ResourceName ="GAFT KT" },
                new ChatBot.Resource { ResourceName ="GAFT Architecture" },
                new ChatBot.Resource { ResourceName ="WiFi Trouble" },
                new ChatBot.Resource { ResourceName ="Wifi Ticket" }
            };
            return resourceList;
        }
    }
}