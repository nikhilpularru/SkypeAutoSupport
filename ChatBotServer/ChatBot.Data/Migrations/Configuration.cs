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
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ChatBotContext context)
        {
            SeedAllProblemsCategoriesResponces().ForEach(c => context.Problems.AddOrUpdate(c));
            //SeedAllCatagoriesResponses().ForEach(c => context.Categories.AddOrUpdate(c));
            //SeedAllResources().ForEach(c => context.Resources.AddOrUpdate(c));
            SeedAllDefaultMesseges().ForEach(c => context.DefaultMessages.AddOrUpdate(c));
            context.SaveChanges();
        }


        private List<Problem> SeedAllProblemsCategoriesResponces()
        {
            List<Problem> dataList = new List<Problem>
            {
                new Problem { ProblemName ="TFS" , Categories = new  List<Category> {
                      new Category { CategoryName ="Admin TFS" , Resources =
                            new List<Resource>{ new Resource {  ResourceName = "Please use the following link to raise the request: https://dell.service-now.com/esp/" } } },
                new Category { CategoryName ="TFS Merge", Resources =
                            new List<Resource> { new Resource {ResourceName ="Perform the folowing steps: 1. abc \n 2. abc \n 3. abc \n 3. abc" } } },
                }  },
                new Problem { ProblemName ="GAFT" , Categories = new  List<Category> {
                        new Category { CategoryName ="GAFT KT", Resources =
                            new List<Resource> { new Resource { ResourceName ="Please refer to following Link: https://www.DELLdocumenthub/GAFT/GAFT_KT.docx" } } },
                new Category { CategoryName ="GAFT Team", Resources =
                            new List<Resource> { new Resource { ResourceName ="pavan_bhushan_k_n@dell.com;anand_eswaran@dell.com" } } },

                } },
                new Problem { ProblemName ="WiFi" , Categories = new  List<Category> {
                        new Category { CategoryName ="WiFi Trouble", Resources =
                            new List<Resource> { new Resource { ResourceName ="Use LAN" } } },
                new Category { CategoryName ="Wifi Ticket", Resources =
                    new List<Resource> { new Resource { ResourceName ="Please raise the ticket in the following location: https://dell.service-now.com/esp/ " } } }

                }  }


            };
            return dataList;
        }

        //private List<Category> SeedAllCatagoriesResponses()
        //{
        //    List<Category> categoryList = new List<Category>
        //    {
        //       new Category { CategoryName ="Admin TFS", Resources =
        //            new List<Resource>{ new Resource {  ResourceName = "Please use the following link to raise the request: https://dell.service-now.com/esp/" } } 
        //        },
        //       new Category { CategoryName ="TFS Merge", Resources =
        //            new List<Resource> { new Resource {ResourceName ="Perform the folowing steps: 1. abc \n 2. abc \n 3. abc \n 3. abc" } }
        //        },
        //        new Category { CategoryName ="GAFT KT", Resources =
        //            new List<Resource> { new Resource { ResourceName ="Please refer to following Link: https://www.DELLdocumenthub/GAFT/GAFT_KT.docx" } }
        //        },
        //        new Category { CategoryName ="GAFT Team", Resources =
        //            new List<Resource> { new Resource { ResourceName ="pavan_bhushan_k_n@dell.com;anand_eswaran@dell.com" } }
        //        },
        //        new Category { CategoryName ="WiFi Trouble", Resources =
        //            new List<Resource> { new Resource { ResourceName ="Use LAN" } }
        //        },
        //        new Category { CategoryName ="Wifi Ticket", Resources =
        //            new List<Resource> { new Resource { ResourceName ="Please raise the ticket in the following location: https://dell.service-now.com/esp/ " } }
        //        }
        //    };
        //    return categoryList;
        //}

        //private List<Category> SeedAllCatagories()
        //{
        //    List<Category> catagoryList = new List<Category>
        //    {
        //        new Category { CategoryName ="Admin TFS" },
        //        new Category { CategoryName ="TFS Merge" },
        //        new Category { CategoryName ="GAFT KT" },
        //        new Category { CategoryName ="GAFT Team" },
        //        new Category { CategoryName ="WiFi Trouble" },
        //        new Category { CategoryName ="Wifi Ticket" }
        //    };
        //    return catagoryList;
        //}

        //private List<Resource> SeedAllResources()
        //{
        //    List<Resource> resourceList = new List<Resource>
        //    {
        //        new Resource { ResourceName ="Please use the following link to raise the request: https://dell.service-now.com/esp/" },
        //        new Resource { ResourceName ="Perform the folowing steps: 1. abc \n 2. abc \n 3. abc \n 3. abc" },
        //        new Resource { ResourceName ="Please refer to following Link: https://www.DELLdocumenthub/GAFT/GAFT_KT.docx" },
        //        new Resource { ResourceName ="pavan_bhushan_k_n@dell.com;anand_eswaran@dell.com" },
        //        new Resource { ResourceName ="Use LAN" },
        //        new Resource { ResourceName ="Please raise the ticket in the following location: https://dell.service-now.com/esp/ " }
        //    };
        //    return resourceList;
        //}

        private List<DefaultMessege> SeedAllDefaultMesseges()
        {
            List<DefaultMessege> defaultMessegeList = new List<DefaultMessege>
            {
                new DefaultMessege { MsgRequest ="Hi ", MsgResponse = "Hi :)"},
                new DefaultMessege { MsgRequest ="Hey", MsgResponse = "Hi :)" },
                new DefaultMessege { MsgRequest ="Thanks", MsgResponse = "No Problems :)"   },
                new DefaultMessege { MsgRequest ="Tell me a joke", MsgResponse = "This is a joke" },
                new DefaultMessege { MsgRequest ="multiple_answers", MsgResponse = "Which of the following are you talking about: " },
                new DefaultMessege { MsgRequest ="DEFAULT", MsgResponse = "I wasn't able to identify the query.\n Can you please try again? :o" }
            };
            return defaultMessegeList;
        }



    }
}
