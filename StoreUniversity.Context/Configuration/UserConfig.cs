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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.UserName).IsRequired();
            builder.Property(c => c.Password).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.Image).IsRequired();
        }
    }
}
