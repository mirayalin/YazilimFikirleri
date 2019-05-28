using MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
   public class User:BaseEntity
    {
        [Required(ErrorMessage ="Bu alanın girilmesi zorunludur."),MaxLength(20,ErrorMessage ="Maksimum 20 karakter girilebilir."),MinLength(5,ErrorMessage ="Minimum 5 karakter giriniz"),Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bu alanın girilmesi zorunludur."), MaxLength(20, ErrorMessage = "Maksimum 20 karakter girilebilir."), MinLength(10, ErrorMessage = "Minimum 5 karakter giriniz"), Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Girilen şifreler uyuşmuyor.")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime BirtDate { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }

        [EmailAddress(ErrorMessage = "Lütfen bir email formatında giriş yapınız")]
        public bool IsActive { get; set; }

        public int Following { get; set; }

        public int Followers { get; set; }

        public Guid ActivationCode { get; set; }

        public string Address { get; set; }


        public User()
        {
            IsActive = false;
            Role = Role.Member;
            ActivationCode = Guid.NewGuid();
        }

        //Relational Properties

        public List<Answer> Answers { get; set; }

        public List<Topic> Topics { get; set; }

    }
}
