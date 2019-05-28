using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
   public class Category:IsFavorite
    {
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public string Tag { get; set; }


        //Relational Proerties

        public List<Topic> Topics { get; set; }
    }
}
