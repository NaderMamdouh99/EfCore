using EffCore.Configrations;
using EffCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffCore
{
    internal class ApplicationDbContext :DbContext
    {
        #region connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source =.; DataBase = EFCore;Trusted_Connection=True;");
        }
        #endregion

        #region Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogTypeConfigration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostTypeConfigration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AutorTypeConfigration).Assembly);
            modelBuilder.Entity<Post>(po =>
            {
                po.Property(p => p.Title).IsRequired().HasColumnType("varchar(200)");
                po.Property(p => p.Content).IsRequired().HasColumnName("Post Content");
            });

            #region DataSeeding

            modelBuilder.Entity<Blog>()
                        .HasData(
                            new Blog { Id = 1,Url="Www.google.com", },
                                 new Blog { Id = 2,Url="Www.facebook.com", }                       
                                );

            modelBuilder.Entity<Post>()
                        .HasData(
                                    new Post { Id = 1, Content = "Good Morning", Title = "Shared Post",BlogId=1 }
                                );

            #endregion

        }
        #endregion

        #region DbSet Table
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Stocks> Stocks { get; set; }
        #endregion
    }
}
