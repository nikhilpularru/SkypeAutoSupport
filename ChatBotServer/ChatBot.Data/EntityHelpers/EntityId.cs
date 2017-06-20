using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Data.EntityHelpers
{
    public abstract class EntityId<T>
    {
        public T Id { get; set; }
    }
}
