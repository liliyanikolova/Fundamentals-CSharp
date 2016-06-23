using Orders.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Orders
{
    class MainStatistics
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var mappedData = new DataMapper();
            var allCategories = mappedData.GetAllCategories();
            var allProducts = mappedData.GetAllProducts();
            var allOrders = mappedData.GetAllOrders();

            // Print names of the 5 most expensive products
            string mostExpensiveProducts = GetMostExpensiveProducts(allProducts, 5);
            Console.WriteLine(mostExpensiveProducts);
            
            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            List<ProductCategoryStatistics> productCategoryStatisticses = GetEachCategoryProductCount(allProducts, allCategories);
            foreach (var cateory in productCategoryStatisticses)
            {
                Console.WriteLine("{0}: {1}", cateory.CategoryName, cateory.ProductCount);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            List<ProductOrderedStatistics> mostOrderedProducts = GetMostOrderedProducts(allOrders, allProducts, 5);
            foreach (var product in mostOrderedProducts)
            {
                Console.WriteLine("{0}: {1}", product.ProductName, product.ProductQuantity);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            ProductCategoryStatistics mostProfitableCategory = GetMostProfitableCategory(allOrders, allProducts, allCategories);
            Console.WriteLine("{0}: {1}", mostProfitableCategory.CategoryName, mostProfitableCategory.TotalQuantity);
        }

        // Return the names of the most N expensive products
        public static string GetMostExpensiveProducts(IEnumerable<Product> products, int mostExpensiveProductsCount)
        {
            var mostExpensiveProductsNames = products
                .OrderByDescending(product => product.UnitPrice)
                .Take(mostExpensiveProductsCount)
                .Select(product => product.Name);
            return string.Join(Environment.NewLine, mostExpensiveProductsNames);
        }

        // Return the number of products in each category
        public static List<ProductCategoryStatistics> GetEachCategoryProductCount(IEnumerable<Product> products, IEnumerable<Category> categories)
        {
            var productCAtegoryCount = products
                .GroupBy(product => product.CategoryId)
                .Select(group => new ProductCategoryStatistics { CategoryName = categories.First(category => category.Id == group.Key).Name, ProductCount = group.Count() })
                .ToList();

            return productCAtegoryCount;
        }

        // Return the top N ordered products (by order quantity)
        public static List<ProductOrderedStatistics> GetMostOrderedProducts(IEnumerable<Order> orders, IEnumerable<Product> products, int orderedProductsCount)
        {
            var mostOrderedProducts = orders
                .GroupBy(product => product.ProductId)
                .Select(productGroup => new ProductOrderedStatistics{
                    ProductName = products.First(product => product.Id == productGroup.Key).Name, 
                    ProductQuantity = productGroup.Sum(group => group.Quantity) })
                .OrderByDescending(product => product.ProductQuantity)
                .Take(5)
                .ToList();
            return mostOrderedProducts;
        }

        // The most profitable category
        public static ProductCategoryStatistics GetMostProfitableCategory(
            IEnumerable<Order> orders,
            IEnumerable<Product> products,
            IEnumerable<Category> categories)
        {
            var mostProfitableCategory = orders
                .GroupBy(order => order.ProductId)
                .Select(group => new
                {
                    CategoryId = products.First(
                        product => product.Id == group.Key).CategoryId,
                    Price = products.First(product => product.Id == group.Key).UnitPrice,
                    Quantity = group.Sum(product => product.Quantity)
                })
                .GroupBy(group => group.CategoryId)
                .Select(categoryGroup => new ProductCategoryStatistics
                {
                    CategoryName = categories.First(category => category.Id == categoryGroup.Key).Name,
                    TotalQuantity = categoryGroup.Sum(group => group.Quantity * group.Price)
                })
                .OrderByDescending(g => g.TotalQuantity)
                .First();
            return mostProfitableCategory;
        }
    }
}
