using Cart_Exam.Models;
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
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {

        }
        #region Tables
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User_Role> UsersTORoles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Offcode> Offcodes { get; set; }
        public DbSet<ProductsTOOffcodes> ProductsTOOffcodes { get; set; }
        public DbSet<User_Favorits> Favorits { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }


        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(

                new Role()
                {
                    Id = 100,
                    Name = "Admin"

                },
                new Role()
                {
                    Id = 101,
                    Name = "User"
                }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "لب تاب"
                },
                new Category()
                {
                    Id = 2,
                    Name = "ساعت"
                }
                );
            modelBuilder.Entity<Product>().HasData(

                new Product()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "محصول 1",
                    Price = 12000000,
                    SellRate = 80,
                    Description = "این محصول درجه یک است",

                    
                },

                new Product()
                {
                    Id = 2,
                    CategoryId = 2,
                    Name = "محصول 2",
                    Price = 12000000,
                    SellRate = 20,
                    Description = "این محصول درجه یک است",
                },
                new Product()
                {
                    Id = 3,
                    Name = "محصول 3",
                    CategoryId = 1,
                    SellRate = 11,
                    Price = 12000000,
                    Description = "این محصول درجه یک است"
                },
                new Product()
                {
                    Id = 4,
                    Name = "محصول 4",
                    CategoryId = 1,
                    SellRate = 10,
                    Price = 12000000,
                    Description = "این محصول درجه یک است"
                },
                new Product()
                {
                    Id = 5,
                    Name = "محصول 5",
                    CategoryId = 2,
                    SellRate = 10,
                    Price = 12000000,
                    Description = "این محصول درجه یک است"
                }
                );
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage()
                {
                    ProductImageId = 1,
                    ProductId = 1,
                    ImageName = "Meghdadit[dot]com.jpg"
                },
                new ProductImage()
                {
                    ProductImageId = 2,
                    ProductId = 2,
                    ImageName = "Meghdadit[dot]watchcom.jpg"
                },
                new ProductImage()
                {
                    ProductImageId = 3,
                    ProductId = 3,
                    ImageName = "Meghdadit[dot]com.jpg"
                }, new ProductImage()
                {
                    ProductImageId = 4,
                    ProductId = 4,
                    ImageName = "Meghdadit[dot]com.jpg"
                },
                new ProductImage()
                {
                    ProductImageId = 5,
                    ProductId = 5,
                    ImageName = "Meghdadit[dot]watchcom.jpg"
                }

                );
            modelBuilder.Entity<Offcode>().HasData(
                new Offcode()
                {
                    Id=1,
                    Name = "Develop",
                    Percent = 30
                },
                new Offcode()
                {
                    Id=2,
                    Name = "Electronic",
                    Percent = 60
                });
           
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
