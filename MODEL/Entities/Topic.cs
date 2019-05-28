using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
   public class Topic:LD
    {
        public string Title { get; set; }

        public string Tag { get; set; }
        
        public string Body { get; set; }

        public int UserID { get; set; }

        public int CategoryID { get; set; }


        //Relational Properties

        public Category Category { get; set; }

        public User User { get; set; }
    }
}
