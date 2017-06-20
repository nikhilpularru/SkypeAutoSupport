using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public  class ChatBot: EntityAudit
    {
          public string Name { get; set; }
    }

    public class Problem: EntityAudit
    {
        public string ProblemName { get; set; }
    }

    public class Category: EntityAudit
    {    
        public string CategoryName { get; set; }
    }

    public class DefaultMessage : EntityAudit
    {
        public string MsgRequest { get; set; }
        public string MsgResponse { get; set; }
    }
   
    public class Resource: EntityAudit
    {
        [Column(TypeName = "VARCHAR")]
        [StringLength(500)]
        public string ResourceName { get; set; }
    }

    public  abstract class EntityId <T>
    {
        public T Id { get; set; }
    }

  public abstract class EntityAudit : EntityId<int>
    {
        public DateTime CreatedOn { get; set; } 
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public EntityAudit()
        {
            CreatedOn = DateTime.Now;
            CreatedBy = "Nikhil Pullaru and Pavan bhushan";
            ModifiedOn = DateTime.Now;
        }
    }

    public class ChatBotContext: DbContext
    {
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<DefaultMessage> DefaultMessages { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ChatBotContext(): base("ChatBotConnection")
        {

        }

    }


}
