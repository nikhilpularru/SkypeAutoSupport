namespace Data.Migrations
{
    using ChatBot.Data.Data;
    using ChatBot.Data.Entities;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ChatBotContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ChatBotContext context)
        {
            SeedAllProblems().ForEach(c => context.Problems.AddOrUpdate(c));
            SeedAllCatagories().ForEach(c => context.Categories.AddOrUpdate(c));
            context.SaveChanges();
        }

        private List<Problem> SeedAllProblems()
        {
            List<Problem> problemList = new List<Problem>
            {
                new Problem { ProblemName ="TFS"   },
                new Problem { ProblemName ="GAFT"  },
                new Problem { ProblemName ="WiFi"  }


            };
            return problemList;
        }

        private List<Category> SeedAllCatagories()
        {
            List<Category> catagoryList = new List<Category>
            {
                new Category { CategoryName ="Admin TFS" },
                new Category { CategoryName ="TFS Merge" },
                new Category { CategoryName ="GAFT KT" },
                new Category { CategoryName ="GAFT Architecture" },
                new Category { CategoryName ="WiFi Trouble" },
                new Category { CategoryName ="Wifi Ticket" }
            };
            return catagoryList;
        }

        private List<Resource> SeedAllResources()
        {
            List<Resource> resourceList = new List<Resource>
            {
                new Resource { ResourceName ="Please use the following link to raise the request: https://dell.service-now.com/esp/" },
                new Resource { ResourceName ="Perform the folowing steps: 1. abc \n 2. abc \n 3. abc \n 3. abc" },
                new Resource { ResourceName ="GAFT KT" },
                new Resource { ResourceName ="GAFT Architecture" },
                new Resource { ResourceName ="WiFi Trouble" },
                new Resource { ResourceName ="Wifi Ticket" }
            };
            return resourceList;
        }
    }
}
