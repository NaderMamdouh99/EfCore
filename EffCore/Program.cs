using EffCore.Models;
using Microsoft.EntityFrameworkCore;
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


            #region ِAdd && AddRange
            //var NAtionalty = new Nationalities { Name = "Iran" };
            //_context.Add(NAtionalty);

            //var Nationalties = new List<Nationalities>
            //{
            //    new Nationalities {Name="Gabon"},
            //    new Nationalities {Name="sudan"}
            //};
            //_context.AddRange(Nationalties);


            //_context.SaveChanges();

            #endregion

            #region Global Filter 
            //var posts = _context.Posts.ToList();
            ////var posts = _context.Posts.IgnoreQueryFilters().ToList();
            //foreach (var post in posts)
            //{
            //    Console.WriteLine($"Post Content:{post.Content} --- Post Title: {post.Title}");
            //}
            #endregion

            #region Loading Data 


            #region Egar Loading
            //var Books = _context.Books.Include(a => a.Author).ThenInclude(b=>b.Nationalities).ToList();
            //foreach (var book in Books)
            //    Console.WriteLine($"Book Name : {book.Name} -- Book Price : {book.Price} -- Author Name : {book.Author.DisplayName} -- Nationalitey Name: {book.Author.Nationalities.Name}");

            #endregion

            #region Explicitly Loading
            //var book = _context.Books.SingleOrDefault(b=>b.Id == 3 );

            //_context.Entry(book).Reference(b=>b.Author).Load();

            //Console.WriteLine($"Book Name: {book.Name} -- Author Name: {book.Author.DisplayName} ");
            #endregion

            #region Lazy loading

            #endregion


            #endregion


            #region Travking vs No Tracking

            #region Change Default Behavior
            //_context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            #endregion

            #region Try Tracking and AsNoTracking

            //var books = _context.Books.AsNoTracking().SingleOrDefault(b=>b.Id == 2 );
            //var books = _context.Books.SingleOrDefault(b => b.Id == 2);
            //books.Price = 180;

            //var traking = _context.ChangeTracker.Entries();
            //foreach (var trak in traking)
            //{
            //    Console.WriteLine($"{trak.Entity.ToString()} -- {trak.State}");
            //}
            //_context.SaveChanges(); 
            #endregion

            #endregion

            #region Join

            #region Egar Loading
            //var Books = _context.Books.Include(a=>a.Author).ToList();
            //foreach (var book in Books)
            //    Console.WriteLine($"Book Name : {book.Name} -- Book Price : {book.Price} -- Author Name : {book.Author.DisplayName}");

            #endregion

            #region Inner join

            //var Books = _context.Books
            //            .Join(
            //                        _context.Authors,
            //                        book => book.AuthorId,
            //                        Author => Author.Id,
            //                        (book, Author) => new
            //                        {
            //                            BookName = book.Name,
            //                            BookPrice = book.Price,
            //                            AuthorName = Author.DisplayName
            //                        }
            //                    );

            //foreach (var book in Books)
            //    Console.WriteLine($"Book Name : {book.BookName} - Book Price : {book.BookPrice} - Author Name : {book.AuthorName}"); 
            #endregion

            #endregion

            #region GroupBy


            //var Industriey = _context.Stocks
            //    .GroupBy(s => s.Balance).Count();
            //Console.WriteLine($"Industry Count: {Industriey}");


            //var Industriey = _context.Stocks
            //    .GroupBy(s => s.Balance).Count();   
            //    .Select(s => new { Name = s.Key, StockCount = s.Count() })
            //    .OrderByDescending(m => m.StockCount);
            //foreach (var Industry in Industriey)
            //    Console.WriteLine($"IndustryName: {Industry.Name} - StockCount: {Industry.StockCount}");
            #endregion

            #region Skip && Take
            //var stocks = GetData(2, 100);
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
            //var Stocks = _context.Stocks.OrderBy(m => m.Id);
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
        #endregion
    }
}
