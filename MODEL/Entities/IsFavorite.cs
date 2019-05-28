using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
   public abstract class IsFavorite:BaseEntity
    {
        public int Favorite { get; set; }
    }
}
