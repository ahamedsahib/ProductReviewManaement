using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagement
{
    public class ProductReviewManager
    {
        /// <summary>
        /// Create list and objects to the list
        /// </summary>

        public int AddProductReviewToList(List<ProductReview> products)
        {
            try
            {
                //Adding 25 entries to list
               
                products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 10, isLike = true });
                products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 6, isLike = true });
                products.Add(new ProductReview() { productId = 7, userId = 8, review = "Average", rating = 9, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 6, isLike = false });
                products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 10, isLike = true });
                products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 1, userId = 1, review = "Good", rating = 8, isLike = true });
                products.Add(new ProductReview() { productId = 2, userId = 2, review = "Average", rating = 8, isLike = true });
                products.Add(new ProductReview() { productId = 1, userId = 2, review = "Bad", rating = 8, isLike = false });
                products.Add(new ProductReview() { productId = 5, userId = 9, review = "Average", rating = 7, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 11, review = "Good", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 7, userId = 4, review = "Good", rating = 9, isLike = true });
                products.Add(new ProductReview() { productId = 9, userId = 8, review = "Average", rating = 10, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 6, isLike = false });
                products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 3, isLike = true });
                products.Add(new ProductReview() { productId = 2, userId = 5, review = "Bad", rating = 7, isLike = false });
                products.Add(new ProductReview() { productId = 1, userId = 1, review = "Very Good", rating = 9, isLike = true });
                products.Add(new ProductReview() { productId = 7, userId = 10, review = "Very Good", rating = 8, isLike = true });
                products.Add(new ProductReview() { productId = 9, userId = 5, review = "Very Good", rating = 7, isLike = true });
                products.Add(new ProductReview() { productId = 10, userId = 3, review = "Bad", rating = 9, isLike = false });
                products.Add(new ProductReview() { productId = 12, userId = 3, review = "Bad", rating = 6, isLike = false });
                products.Add(new ProductReview() { productId = 14, userId = 15, review = "Very Good", rating = 9, isLike = true });
                products.Add(new ProductReview() { productId = 18, userId = 9, review = "Bad", rating = 7, isLike = false });
                products.Add(new ProductReview() { productId = 13, userId = 1, review = "Very Good", rating = 6, isLike = true });

                IterateList(products);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return products.Count;
        }
        /// <summary>
        /// Iterate through list and print
        /// </summary>
        public static void IterateList(List<ProductReview> products)
        {
            try
            {
                foreach (ProductReview i in products)
                {
                    Console.WriteLine($"ProductId:{i.productId}\t UserId:{i.userId}\t Review:{i.review}\tRating:{i.rating}\tIsLike:{i.isLike}\t");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// Method to retreive top 3 ratings records
        /// </summary>
        public int RetrieveTopThreeRating(List<ProductReview> products)
        {
             AddProductReviewToList(products);
            //Using Linq query sort product list  descending order and take first 3 elements
            var res = (from product in products orderby product.rating descending select product).Take(3).ToList();
            Console.WriteLine("---------------------- TOP 3 RATING----------------------");
            IterateList(res);
            return res.Count;
        }

        /// <summary>
        /// Method to retreive particular records
        /// </summary>

        public int RetrieveParticularProduct(List<ProductReview> products)
        {
            AddProductReviewToList(products);
            //Using Linq retrieve particular product id and rating
            var result = (from product in products where (product.productId == 1 || product.productId == 4 || product.productId == 9) && product.rating > 6 select product).ToList();
            Console.WriteLine("------- Records-------");
            IterateList(result);
            return result.Count;
        }

        /// <summary>
        /// Method to show how many product exists and count of product
        /// </summary>
        public int CountProductId(List<ProductReview> products)
        {
            int totalProductsCount = 0;
            AddProductReviewToList(products);
            //Using Linq retreive particular records
            var res = products.GroupBy(x => x.productId).Select(product => new { productId = product.Key, Count = product.Count()});
            Console.WriteLine("------------------- Records----------------------");
            foreach (var product in res)
            {
                Console.WriteLine($"ProductId = {product.productId}\t Count={product.Count}\n");
                totalProductsCount++;
            }
            return totalProductsCount;
        }

        /// <summary>
        /// Method to retreive only id and review using select
        /// </summary>
        public int RetrieveProductIdAndReview(List<ProductReview> products)
        {
            //counter variable
            int count = 0;
            AddProductReviewToList(products);
            var result = products.Select(product => new { productId = product.productId, review = product.review }).ToList();
            foreach (var product in result)
            {
                Console.WriteLine($"ProductId = {product.productId}\t Review={product.review}\n");
                //increment the count
                count++;
            }
            return count;
        }

        /// <summary>
        ///  method to skip 5 records
        /// </summary>
        public int SkipRecords(List<ProductReview> products)
        {

            try
            {
                AddProductReviewToList(products);
                //Using Linq sort product list in ascending order and skip 5 elements
                var result = (from product in products orderby product.productId ascending select product).Skip(5).ToList();
                Console.WriteLine("-----------------EXCEPt FIRST 5----------------------");
                IterateList(result);
                return result.Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }


        }

        /// <summary>
        /// Method to create datatable and Insert data
        /// </summary>

        public DataTable CreateDataTable(List<ProductReview> products)
        {
            AddProductReviewToList(products);
            //Initialise datatable
            DataTable Table = new DataTable();
            //add cloumn names to data table 
            Table.Columns.Add("productId", typeof(int));
            Table.Columns.Add("userId", typeof(int));
            Table.Columns.Add("rating", typeof(int));
            Table.Columns.Add("review", typeof(string));
            Table.Columns.Add("isLike", typeof(bool));

            foreach (var data in products)
            {
                //add rows from product list to data table
                Table.Rows.Add(data.productId, data.userId, data.rating, data.review, data.isLike);
            }
            return Table;
        }
    }
}
