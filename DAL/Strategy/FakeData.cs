using DAL.Context;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Strategy
{
    public class FakeData:CreateDatabaseIfNotExists<MyDBContext>
    {
        protected override void Seed(MyDBContext context)
        {
            for (int i = 0; i < 50; i++)
            {
                User u = new User();

                u.Name = new Bogus.DataSets.Name("tr").FirstName();
                u.LastName = new Bogus.DataSets.Name("tr").LastName();
                u.UserName = new Bogus.DataSets.Internet("tr").UserName();
                u.Password = new Bogus.DataSets.Internet("tr").Password();
                u.Email = new Bogus.DataSets.Internet("tr").Email();
                u.Address = new Bogus.DataSets.Address("tr").FullAddress();
                u.Followers = new Bogus.Randomizer().Int(0, 200);
                u.Followers = new Bogus.Randomizer().Int(0, 200);
                u.BirtDate = new Bogus.Person().DateOfBirth.Date;

                context.Users.Add(u);
               
            }
            context.SaveChanges();
        }
    }
}
