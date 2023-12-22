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
    public class OffCodeConfig : IEntityTypeConfiguration<Offcode>
    {
        public void Configure(EntityTypeBuilder<Offcode> builder)
        {
            builder.HasKey(c=>c.Id);
            builder.Property(c => c.Percent).IsRequired();
            builder.Property(c => c.Name).IsRequired();

        }
    }
}
