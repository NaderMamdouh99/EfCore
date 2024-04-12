using EffCore.Models;
using System;

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

        }
    }
}
