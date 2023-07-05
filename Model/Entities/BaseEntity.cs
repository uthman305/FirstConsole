using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardConsole.Model.Entities
{
    public abstract class BaseEntity
    {
        public int Id;

        public BaseEntity(int id)
        {
            Id = id;
        }
    }
}