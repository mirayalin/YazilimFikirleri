using MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
   public abstract class BaseEntity
    {
        public int ID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public Status DataStatus { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;

            DataStatus = Status.Inserted;
        }
    }
}
