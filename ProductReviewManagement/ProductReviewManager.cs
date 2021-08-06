using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
                products.Add(new ProductReview() { productId = 19, userId = 8, review = "Average", rating = 9, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 6, isLike = false });
                products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 10, isLike = true });
                products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 1, userId = 1, review = "Good", rating = 8, isLike = true });
                products.Add(new ProductReview() { productId = 2, userId = 2, review = "Average", rating = 8, isLike = true });
                products.Add(new ProductReview() { productId = 1, userId = 2, review = "Bad", rating = 8, isLike = false });
                products.Add(new ProductReview() { productId = 5, userId = 9, review = "Average", rating = 7, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 11, review = "Good", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 4, review = "Good", rating = 9, isLike = true });
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

    }
}
