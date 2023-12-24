using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreUniversityModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversity.Context.Configuration
{
    public class ProductImageConfig : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(c => c.ProductImageId);
            builder.Property(c => c.ImageName).IsRequired();
            builder.HasOne(c => c.Product)
                .WithMany(c => c.images)
                .HasForeignKey(c => c.ProductId)
                .IsRequired();
        }
    }
}
