using EffCore.Models;
using System;
using System.Linq;

namespace EffCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();


            #region Default Value 
            //var Blog = new Blog()
            //{
            //    Url="Test 0.1",
            //    Rate =7,
            //    CreatedOn = DateTime.Now,
            //};
            //_context.Add(Blog);
            //_context.SaveChanges(); 
            #endregion

            #region ComputedColumnTypeSql 

            //var Author = new Author()
            //{
            //    FirstName = "Nader",
            //    LastName = "Mamdouh",

            //};
            //_context.Add(Author);
            //_context.SaveChanges();



            //var Author = _context.Authors.Find(1);

            //Author.LastName = "Mohamed";
            //_context.SaveChanges(); 
            #endregion


            DataSeeding();
        }

        #region Methods to insert Data in Sql (Data Seeding)
        public static void DataSeeding()
        {
            using var context = new ApplicationDbContext();
            context.Database.EnsureCreated();
            var blog = context.Blogs.FirstOrDefault(b => b.Url == "www.gmail.com");
            if (blog == null)
                context.Add(new Blog { Url = "www.gmail.com", Rate = 7, });
            context.SaveChanges();
        } 
        #endregion
    }
}
