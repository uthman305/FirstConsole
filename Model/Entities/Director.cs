using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardConsole.Model.Entities
{
    public class Director : BaseEntity
    {
        public string DirectorId;
        public string Pin;

        public Director(int id, string directorId, string pin) : base(id)
        {
            DirectorId = directorId;
            Pin = pin;
        }
    }
}