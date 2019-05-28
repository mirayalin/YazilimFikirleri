using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.Options
{
   public class TopicMap:BaseMap<Topic>
    {
        public TopicMap()
        {
            ToTable("Konular");

            Property(x => x.Title).HasColumnName("Konu Başlığı").HasMaxLength(50).IsRequired();
            Property(x => x.Tag).HasColumnName("Etiketler").IsOptional();
            Property(x => x.Body).HasColumnName("Konu İçeriği").IsRequired();
            Property(x => x.Like).HasColumnName("Beğeni").IsOptional();
            Property(x => x.Dislike).HasColumnName("Beğenmeme").IsOptional();
            Property(x => x.Favorite).HasColumnName("Favori").IsOptional();

            Ignore(x => x.ID);

            HasKey(x => new
            {
                x.UserID,
                x.CategoryID
            });
        }
    }
}
