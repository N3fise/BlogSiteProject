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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("3013B78E-C011-4C50-9498-6885ED538514"),
                FileName = "image/testimage",
                FileType = "jpg",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,

            },
            new  Image
            {
               
                Id = Guid.Parse("C55D0CB5-2188-4725-AFD9-430E3DC7893D"),
                FileName = "image/vstestimage",
                FileType = "jpg",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,

            }
            );
        }

    }
}
