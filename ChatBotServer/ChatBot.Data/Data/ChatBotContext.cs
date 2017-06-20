using ChatBot.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Data.Data
{
    public class ChatBotContext : DbContext
    {
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<DefaultMessage> DefaultMessages { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ChatBotContext() : base("ChatBotConnection")
        {

        }

    }
}
