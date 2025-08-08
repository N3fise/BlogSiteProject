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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            //builder.Property(x => x.Title).HasMaxLength(150); // sql'deki data type kısını buradan düzenledik. 
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "ASP.NET CORE deneme makalesi 1",
                Content = "ASP.NET CORE A custom launcher and content management app for Assetto Corsa. Still in development. From the authors of Cars Manager.\r\n\r\nBasic (Lite) version is free and contains all features listed below as key features and more. If you want to support development and get the access to WIP features and pre-release builds, please consider making a donation (any amount), and you’ll get an app key enabling new features.",
                ViewCount = 15.ToString(),
                CategoryId = Guid.Parse("4642999A-E595-42C7-AACF-1D7201B5C45A"),
                ImageId = Guid.Parse("3013B78E-C011-4C50-9498-6885ED538514"),
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now

            },
            new Article
            {

                Id = Guid.NewGuid(),
                Title = "visual studio deneme makalesi 1",
                Content = "visual studio A custom launcher and content management app for Assetto Corsa. Still in development. From the authors of Cars Manager.\r\n\r\nBasic (Lite) version is free and contains all features listed below as key features and more. If you want to support development and get the access to WIP features and pre-release builds, please consider making a donation (any amount), and you’ll get an app key enabling new features.",
                ViewCount = 15.ToString(), //?????????????????
                CategoryId = Guid.Parse("27FE0E34-5996-4727-8AAF-8EC6F8950563"),
                ImageId = Guid.Parse("C55D0CB5-2188-4725-AFD9-430E3DC7893D"),
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            }



            ) ;

        }
    }
}
