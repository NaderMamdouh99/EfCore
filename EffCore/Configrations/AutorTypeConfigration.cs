using EffCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffCore.Configrations
{
    internal class AutorTypeConfigration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(d => d.DisplayName).HasComputedColumnSql("[LastName] + ', ' + [FirstName]");
            //builder.HasOne(e => e.Employee)
            //       .WithOne(a => a.Author)
            //       .HasForeignKey<Author>(a => a.EmployeeId);

        }
    }
}
