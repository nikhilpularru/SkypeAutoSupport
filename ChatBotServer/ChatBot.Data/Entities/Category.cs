using ChatBot.Data.EntityHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Data.Entities
{
    public class Category : EntityAudit
    {
        public string CategoryName { get; set; }

        public virtual ICollection<Problem> Problems { get; set; }
    }
}
