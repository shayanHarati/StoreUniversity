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
    internal class ProductsTOOffcodesConfig : IEntityTypeConfiguration<ProductsTOOffcodes>
    {
        public void Configure(EntityTypeBuilder<ProductsTOOffcodes> builder)
        {
            builder.HasKey(c => c.ID);
            builder.HasOne(c => c.Product)
               .WithMany(c => c.Offcodes)
               .HasForeignKey(c => c.ProductId)
               .IsRequired();
            builder.HasOne(c => c.Offcode)
               .WithMany(c => c.Products)
               .HasForeignKey(c => c.OffCodeId)
               .IsRequired();
        }
    }
}
