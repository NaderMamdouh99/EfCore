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
    internal class PostTypeConfigration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            // Edit Column Name  
            builder.Property(p => p.Title).IsRequired().HasColumnName("Post Title");
            // Edit Column Type 
            builder.Property(p => p.Content).IsRequired().HasColumnType("nvarchar(200)");

        }
    }
}
