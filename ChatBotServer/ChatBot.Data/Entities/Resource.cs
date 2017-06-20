using ChatBot.Data.EntityHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Data.Entities
{
    public class Resource : EntityAudit
    {
        [Column(TypeName = "VARCHAR")]
        [StringLength(500)]
        public string ResourceName { get; set; }
    }
}
