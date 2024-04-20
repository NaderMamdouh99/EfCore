using EffCore.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EffCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();

            #region GroupBy
            //var Industriey = _context.Stocks
            //    .GroupBy(s => s.Industry)
            //    .Select(s => new { Name = s.Key, StockCount = s.Count() })
            //    .OrderByDescending(m => m.StockCount);

            //foreach (var Industry in Industriey)
            //    Console.WriteLine($"IndustryName: {Industry.Name} - StockCount: {Industry.StockCount}");
            #endregion

            #region Skip && Take
            //var stocks = GetData(4, 20);
            //foreach (var stock in stocks)
            //    Console.WriteLine($"Id: {stock.Id} - Name: {stock.Name}");
            #endregion

            #region Order By Descending && ThenBy
            //var stocks = _context.Stocks.OrderBy(m => m.Industry).ThenByDescending(m => m.Balance).ToList();

            //foreach (var stock in stocks)
            //{
            //    Console.WriteLine($"Industry: {stock.Industry} - Balance: {stock.Balance}");
            //}
            #endregion

            #region Where && Last && OrderBy
            //var Stocks = _context.Stocks.OrderBy(m=>m.Id).Last();
            //var Stocks = _context.Stocks.Where(m => m.Id < 500 && m.Name.StartsWith("z")).ToList();
            //foreach (var stock in Stocks)
            //    Console.WriteLine($"Id: {stock.Id} Name: {stock.Name}"); 
            #endregion

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

        #region Pagenation
        public static List<Stocks> GetData(int pageNumber , int pageSize)
        {
            using var context = new ApplicationDbContext();
            return context.Stocks.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }


        #region Elish
        //public static int UpdateData(string _name,string _balance)
        //{
        //    int status = 0;
        //    using var context = new ApplicationDbContext();
        //    status = context.Stocks.Where(x=>x.Id ==1).;
        //    return status;
        //} 
        #endregion


        #endregion
    }
}
