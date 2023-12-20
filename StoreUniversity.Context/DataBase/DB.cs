using Microsoft.EntityFrameworkCore;
using StoreUniversity.Context.Configuration;
using StoreUniversityModels.Product;
using StoreUniversityModels.User;
using StoreUniversityModels.User.UserRelations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversity.Context.DataBase
{
    public class DB:DbContext
    {
        public DB(DbContextOptions<DB> options):base(options)
        {
            
        }
        #region Tables
        public DbSet<User>  Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User_Role> UsersTORoles { get; set; }
        public DbSet<Product> Products { get; set; }
        
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.ApplyConfiguration(new User_Role_Config());
            base.OnModelCreating(modelBuilder);
        }
    }
}
