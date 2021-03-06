﻿using ChatBot.Data.Entities;
using System.Data.Entity;

namespace ChatBot.Data.Data
{
    public class ChatBotContext : DbContext
    {
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<DefaultMessege> DefaultMessages { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ChatBotContext() : base("ChatBotConnection")
        {
            
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ChatBotContext>());
            


        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Problem>().HasMany<Category>(c => c.Categories)
                  .WithMany(p => p.Problems)
                  .Map(
                 pc =>
                 {
                     pc.MapLeftKey("ProblemRefId");
                     pc.MapRightKey("CategoryRefId");
                     pc.ToTable("ProblemCategory");
                 }
                );

            modelBuilder.Entity<Category>().HasMany<Resource>(c => c.Resources)
                  .WithMany(p => p.Categories)
                  .Map(
                 pc =>
                 {
                     pc.MapLeftKey("CategoryRefId");
                     pc.MapRightKey("ResourceRefId");
                     pc.ToTable("CategoryResource");
                 }
                );

        }
    }
}
