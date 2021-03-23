using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Data.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace eShopSolution.Data.Extention
{
    public static class ModelBuilderExtenstion
    {
        public static void See(this ModelBuilder modelBuilder)
        {
            //Data seeding
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "this is home page of eshopsolution" },
                new AppConfig() { Key = "KeyWork", Value = "this is key work of eshopsolution" },
                new AppConfig() { Key = "HomeDescription", Value = "this is home description of eshopsolution" }
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact() { Name = "Đỗ Nguyễn Anh Khoa", Email = "KhoaDNA@gmail.com", PhoneNumber = 0989966773, Message = "I'm KhoaDNA" },
                new Contact() { Name = "Nguyễn Đình Toại", Email = "ToaiND@gmail.com", PhoneNumber = 0989966773, Message = "I'm ToaiND" },
                new Contact() { Name = "Nguyễn Ngọc Thuận", Email = "ThuanNN@gmail.com", PhoneNumber = 0989966773, Message = "I'm ThuanNN" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "Tiếng Anh", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    SortOrder = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    Status = Status.Active,
                },
                new Category()
                {
                    Id = 2,
                    SortOrder = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    Status = Status.Active,
                });

            modelBuilder.Entity<CategoriesTransaction>().HasData(
                        new CategoriesTransaction() { CategoryId = 1, Name = "Áo Nam", LanguageId = "Vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                        new CategoriesTransaction() { CategoryId = 1, Name = "Men Shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirt product for men", SeoTitle = "The shirt product for men" },
                        new CategoriesTransaction() { CategoryId = 2, Name = "Áo Nữ", LanguageId = "Vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ" },
                        new CategoriesTransaction() { CategoryId = 2, Name = "women Shirt", LanguageId = "en-US", SeoAlias = "men-women", SeoDescription = "The shirt product for women", SeoTitle = "The shirt product for women" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Price = 10000,
                    OriginalPrice = 5000,
                    Stock = 0,
                    VewCount = 0,
                    DateCreated = DateTime.Now,
                    ProductInCategories = new List<ProductInCategory>()
                    {
                        new ProductInCategory(){CategoryId = 1}
                    }
                },
                new Product()
                {
                    Id = 2,
                    Price = 20000,
                    OriginalPrice = 10000,
                    Stock = 0,
                    VewCount = 0,
                    DateCreated = DateTime.Now,
                    ProductInCategories = new List<ProductInCategory>()
                    {
                        new ProductInCategory(){CategoryId = 1}
                    }
                });

            modelBuilder.Entity<ProductTransaction>().HasData(
                        new ProductTransaction() { ProductId= 1,Name = "Áo sơ mi nam xanh blue", LanguageId = "vi-VN", SeoAliat = "Ao-so-mi-nam-xanh-blue", SeoTitle = "Sản phẩm áo thời trang nam", SeoDescription = "Sản phẩm áo thời trang nam", Description = "", Details = "Mô tả sản phẩm" },
                        new ProductTransaction() { ProductId= 1,Name = "Men shirt blue", LanguageId = "en-US", SeoAliat = "men-shirt", SeoTitle = "The shirt product for men", SeoDescription = "The shirt product for men", Description = "", Details = "description of product" },
                        new ProductTransaction() { ProductId= 2,Name = "Áo sơ mi nữ", LanguageId = "vi-VN", SeoAliat = "Ao-so-mi-nư", SeoTitle = "Sản phẩm áo thời trang nữ", SeoDescription = "Sản phẩm áo thời trang nữ", Description = "", Details = "Mô tả sản phẩm" },
                        new ProductTransaction() { ProductId= 2,Name = "Women shirt blue", LanguageId = "en-US", SeoAliat = "women-shirt", SeoTitle = "The shirt product for women", SeoDescription = "The shirt product for women", Description = "", Details = "description of product" }
            );
        }
    }
}
