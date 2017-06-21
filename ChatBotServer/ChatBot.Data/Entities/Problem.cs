using ChatBot.Data.EntityHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Data.Entities
{
    public class Problem : EntityAudit
    {
        public string ProblemName { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
