using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
   public abstract class LD:IsFavorite
    {
        public int Like { get; set; }

        public int Dislike { get; set; }

        
    }
}
