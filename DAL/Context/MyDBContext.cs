using DAL.Strategy;
using MAP.Options;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
   public class MyDBContext:DbContext
    {
        public MyDBContext():base("YazilimDB")
        {
            

            //bu alanda iki kez validation calıstırıp password length yüzünden hashleme sonrasındaki kontrolü tekrar yapmasını istemiyorsanız
            Configuration.ValidateOnSaveEnabled = false;
            Database.SetInitializer(new FakeData());//Hazır verilerin çekilebilmesi için bu kod satırı gereklidir.
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AnswerMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new TopicMap());
        }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Topic> Topics { get; set; }

    }
}
