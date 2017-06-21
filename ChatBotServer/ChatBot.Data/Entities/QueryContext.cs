using ChatBot.Data.EntityHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Data.Entities
{
    class QueryContext: EntityAudit
    {
        public string SIP { get; set; }
        public string ContextID { get; set; }
        public string MessegeLog { get; set; }
        public DateTime RecievedOn { get; set; }
    }
}
