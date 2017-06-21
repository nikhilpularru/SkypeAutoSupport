using ChatBot.Data.Entities;
using System.Data.Entity;

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
           // Database.SetInitializer(new DropCreateDatabaseAlways<ChatBotContext>());
        }

    }
}
