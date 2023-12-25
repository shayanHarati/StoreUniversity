﻿using Microsoft.EntityFrameworkCore;
using StoreUniversity.Context.Configuration;
using StoreUniversityModels.Product;
using StoreUniversityModels.User;
using StoreUniversityModels.User.UserRelations;
using StoreUniversityModels.Wallet;
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
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Offcode> Offcodes { get; set; }
        public DbSet<ProductsTOOffcodes>  ProductsTOOffcodes { get; set; }
        public DbSet<User_Favorits>  Favorits { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }


        public DbSet<Wallet>  Wallets { get; set; }
        public DbSet<WalletType> WalletTypes { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                
                new Role()
                {
                    Id = 100,
                    Name="Admin"

                },
                new Role()
                {
                    Id=101,
                    Name="User"
                }
                );
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id=100,
                    UserName="Admin",
                    Password="Admin",
                    Email="Admin@gmail.com",
                    Image= "user.png"
                }
                );
            modelBuilder.Entity<User_Role>().HasData(
                new User_Role()
                {
                    Id=1,
                    RoleId=100,
                    UserId=100
                }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id=1,
                    Name = "لب تاب"
                },
                new Category()
                {
                    Id=2,
                    Name="ساعت"
                }
                );
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.ApplyConfiguration(new User_Role_Config());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new OffCodeConfig());
            modelBuilder.ApplyConfiguration(new ProductsTOOffcodesConfig());
            modelBuilder.ApplyConfiguration(new ProductImageConfig());
            modelBuilder.ApplyConfiguration(new User_FavoritsConfig());


            base.OnModelCreating(modelBuilder);
        }
    }
}
