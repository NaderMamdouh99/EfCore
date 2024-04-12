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
    internal class BlogTypeConfigration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            // Edit Column Name
            builder.Property(m=>m.Url).IsRequired().HasColumnName("Post Url");
            // Default Value
            builder.Property(b => b.Rate).HasDefaultValue(2);
            builder.Property(b => b.CreatedOn).HasDefaultValueSql("GETDATE()");
        }
    }
}
