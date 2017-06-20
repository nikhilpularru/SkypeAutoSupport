using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Data.EntityHelpers
{
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
}
