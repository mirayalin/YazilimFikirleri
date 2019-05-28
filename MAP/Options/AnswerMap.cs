using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.Options
{
   public class AnswerMap:BaseMap<Answer>
    {
        public AnswerMap()
        {
            ToTable("Cevaplar");

            Property(x => x.Like).HasColumnName("Beğeni").IsOptional();
            Property(x => x.Dislike).HasColumnName("Beğenmeme").IsOptional();
            Property(x => x.Favorite).HasColumnName("Favori").IsOptional();

            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.TopicID,
                x.UserID
            });
        }
    }
}
