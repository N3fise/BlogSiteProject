using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder) 
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("4642999A-E595-42C7-AACF-1D7201B5C45A"),
                Name = "Asp.net core deneme makalesi 1",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
            new Category
            {
                Id = Guid.Parse("27FE0E34-5996-4727-8AAF-8EC6F8950563"),
                Name = "Visual studio deneme makalesi 1",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            });
        }

    }
}
