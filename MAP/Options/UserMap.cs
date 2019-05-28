using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.Options
{
   public class UserMap:BaseMap<User>
    {
        public UserMap()
        {
            ToTable("Kullanıcılar");

            Property(x => x.Name).HasColumnName("İsim").HasMaxLength(50).IsRequired();
            Property(x => x.LastName).HasColumnName("Soyisim").HasMaxLength(50).IsRequired();
            Property(x => x.Password).HasColumnName("Şifre").HasMaxLength(200).IsRequired();
            Ignore(x => x.RePassword);
            Property(x => x.Email).HasColumnName("E-Posta").HasMaxLength(200).IsRequired();
            Property(x => x.IsActive).HasColumnName("Hesap Aktif mi?");
            Property(x => x.Address).HasColumnName("Adres").IsOptional();
            Property(x => x.UserName).HasColumnName("Kullanıcı Adı").HasMaxLength(70).IsRequired();
            Property(x => x.BirtDate).HasColumnName("Doğum Tarihi").HasColumnType("datetime2").IsRequired();
            Property(x => x.Role).HasColumnName("Rolü");
            Property(x => x.Followers).HasColumnName("Takipçi Sayısı");
            Property(x => x.Following).HasColumnName("Takip Edilen Sayısı");
            Property(x => x.ActivationCode).HasColumnName("Aktivasyon Kodu");
        }
    }
}
