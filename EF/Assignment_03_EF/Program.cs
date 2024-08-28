//============================================================================================\\
//===================================Assignment_03(EF)========================================\\
//============================================================================================\\

using Assignment_03_EF.Context;
using Assignment_03_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_03_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                #region self relation

                //var parentCategory = new Category
                //{
                //    CategoryName = "Electronics",
                //    Description = "Test"
                //};

                //var childCategory = new Category
                //{
                //    CategoryName = "Laptops",
                //    Description = "Test1",
                //    ParentCategory = parentCategory
                //};

                //context.Categories.Add(parentCategory);
                //context.Categories.Add(childCategory);

                #endregion

                //====================================================================================\\

                #region join 

                //var Products = context.Products;
                //var Categories= context.Categories;
                //var fluent = Products
                //    .Join(Categories,
                //    product => product.CategoryID,
                //    category => category.CategoryID,
                //    (product, category) => new
                //    {
                //        ProductName = product.ProductName,
                //        CategoryName = category.CategoryName,
                //        UnitPrice = product.UnitPrice
                //    }).ToList();

                //foreach (var category in fluent)
                //{
                //    Console.WriteLine(category);
                //}

                #endregion

                //====================================================================================\\

                #region Stored procedure

                //    NorthwindContextProcedures contextProcedures =new NorthwindContextProcedures(context);

                //    var products = contextProcedures.SalesByCategoryAsync("Beverages", "1998").Result;

                //    foreach (var product in products) 
                //        Console.WriteLine($"{product.ProductName} :: {product.TotalPurchase}");

                #endregion

                //====================================================================================\\

                #region run sql query

                //// 1. Execute Select Statement
                //var result = context.Categories.FromSqlRaw($"select * from Categories").ToList();
                //var category = "Beverages";
                //var result = context.Categories.FromSqlInterpolated($"select * from Categories where CategoryName = {category}");
                //var result = context.Categories.Where(x => x.CategoryName == "Beverages");

                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item.CategoryName} :: {item.Description}");
                //}

                //// 2. DML Query
                //context.Database.ExecuteSqlInterpolated($"update Products set ProductName = 'Chai02' where ProductName ='Chai'");

                #endregion

            }
        }
    }
}
