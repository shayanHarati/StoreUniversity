using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreUniversityModels.User.UserRelations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversity.Context.Configuration
{
    public class User_Role_Config : IEntityTypeConfiguration<User_Role>
    {
        public void Configure(EntityTypeBuilder<User_Role> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.User)
                .WithMany(c => c.Roles)
                .HasForeignKey(c => c.UserId)
                .IsRequired();
            builder.HasOne(c => c.Role)
                .WithMany(c => c.Users)
                .HasForeignKey(c => c.RoleId)
                .IsRequired();
        }
    }
}
