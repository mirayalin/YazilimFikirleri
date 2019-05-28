using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
   public class Answer:LD
    {

        public int UserID { get; set; }

        public int TopicID { get; set; }

        //Relational Properties

        public User User { get; set; }

        public Topic Topic { get; set; }


    }
}
