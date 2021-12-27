using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Data seeding
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eshopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is key word of eshopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is Description of eshopSolution" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tieng Viet", IsDefault = true },
                new Language() { Id = "en-US", Name = "Tieng Anh", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Enums.Status.Active,
                    //CategoryTranslations = new List<CategoryTranslation>() {
                    //    new CategoryTranslation() { Name = "Ao nam", LanguageId = "vi-VN", SeoAlias = "ao nam", SeoDescription = "San pham thoi trang ao nam", SeoTitle = "" },
                    //    new CategoryTranslation() { Name = "Men shirt", LanguageId = "en-US", SeoAlias = "mem-shirt", SeoDescription = "the shirt for man", SeoTitle = "" },
                    //}
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Enums.Status.Active,
                    //CategoryTranslations = new List<CategoryTranslation>() {
                    //    new CategoryTranslation() { Name = "Ao nu", LanguageId = "vi-VN", SeoAlias = "ao nu", SeoDescription = "San pham thoi trang ao nu", SeoTitle = "San pham thoi trang ao nu" },
                    //    new CategoryTranslation() { Name = "Woman shirt", LanguageId = "en-US", SeoAlias = "Woman-shirt", SeoDescription = "the shirt for Woman", SeoTitle = "the shirt for Woman" },
                    //}
                }
                );
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() {Id = 1, CategoryId = 1, Name = "Ao nam", LanguageId = "vi-VN", SeoAlias = "ao nam", SeoDescription = "San pham thoi trang ao nam", SeoTitle = "" },
                new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men shirt", LanguageId = "en-US", SeoAlias = "mem-shirt", SeoDescription = "the shirt for man", SeoTitle = "" },
                new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Ao nu", LanguageId = "vi-VN", SeoAlias = "ao nu", SeoDescription = "San pham thoi trang ao nu", SeoTitle = "San pham thoi trang ao nu" },
                new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Woman shirt", LanguageId = "en-US", SeoAlias = "Woman-shirt", SeoDescription = "the shirt for Woman", SeoTitle = "the shirt for Woman" }
                );

            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 1,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   
                   //ProductInCategories = new List<ProductInCategory>
                   //{
                   //    new ProductInCategory(){CategoryId = 1}
                   //}
               });
            modelBuilder.Entity<ProductTranslation>().HasData(
                        new ProductTranslation() {
                            Id = 1,
                            ProductId = 1,
                            Name = "Ao nam viettien",
                            LanguageId = "vi-VN",
                            SeoAlias = "ao nam",
                            SeoDescription = "Ao nam viettien",
                            SeoTitle = "Ao nam viettien" ,
                            Details = "Ao nam viettien",
                            Description="Ao nam viettien"},
                        new ProductTranslation() {
                            Id = 2,
                            ProductId = 1,
                            Name = "Viet tien Men shirt",
                            LanguageId = "en-US",
                            SeoAlias = "viet tien T-Shirt",
                            SeoDescription = "viet tien T-Shirt",
                            SeoTitle = "viet tien T-Shirt" ,
                            Details = "viet tien T-Shirt",
                            Description ="viet tien T-Shirt"}

                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1}
                );


        }
    }
}
