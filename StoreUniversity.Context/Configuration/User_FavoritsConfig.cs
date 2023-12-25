using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreUniversityModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversity.Context.Configuration
{
    public class User_FavoritsConfig : IEntityTypeConfiguration<User_Favorits>
    {
        public void Configure(EntityTypeBuilder<User_Favorits> builder)
        {
            builder.HasKey(c => c.UserFavoritId);
            builder.HasOne(c => c.User)
                .WithMany(c => c.Favorits)
                .HasForeignKey(c => c.UserId)
                .IsRequired();
            builder.HasOne(c => c.product)
               .WithMany(c => c.UserFavorits)
               .HasForeignKey(c => c.ProductId)
               .IsRequired();
        }
    }
}
