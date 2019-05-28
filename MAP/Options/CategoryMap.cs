using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.Options
{
   public class CategoryMap:BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("Kategoriler");

            Property(x => x.CategoryName).HasColumnName("Kategori İsmi").IsRequired();

            Property(x => x.Description).HasColumnName("Kategori Açıklaması");

            Property(x => x.Tag).HasColumnName("Etiketler").IsOptional();

            Property(x => x.Favorite).HasColumnName("Favori").IsOptional();
        }
    }
}
