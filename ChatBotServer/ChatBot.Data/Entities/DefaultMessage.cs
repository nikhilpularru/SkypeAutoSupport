using ChatBot.Data.EntityHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Data.Entities
{
    public class DefaultMessage : EntityAudit
    {
        public string MsgRequest { get; set; }
        public string MsgResponse { get; set; }
    }
}
