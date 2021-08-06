using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System;
using System.Collections.Generic;

namespace ProductReviewTest
{
    [TestClass]
    public class UnitTest1
    {
        ProductReviewManager productReviewManager;
        List<ProductReview> reviewList;
        
        [TestInitialize]
        public void SetUp()
        {
            reviewList = new List<ProductReview>();
            productReviewManager = new ProductReviewManager();
        }
        /// <summary>
        /// Test method to create and add reviews to the list
        /// </summary>
        [TestMethod]
        public void TestMethodForAddDataToList()
        {
            try
            {
                int actual, expected = 25;
                actual = productReviewManager.AddProductReviewToList(reviewList);
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// test method to retreive top 3 Ratin
        /// </summary>
        [TestMethod]
        public void TestMethodRetreiveTop3()
        {
            try
            {
                int actual, expected = 3;
                actual = productReviewManager.RetrieveTopThreeRating(reviewList);
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// test method to retreive  records
        /// </summary>
        [TestMethod]
        public void TestMethodRetreiveParticularRecords()
        {
            try
            {
                int actual, expected = 5;
                actual = productReviewManager.RetrieveParticularProduct(reviewList);
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Method to show how many product exists and count of product
        /// </summary>
        [TestMethod]
        public void TestMethodCountProductId()
        {
            try
            {
                int actual, expected = 12;
                actual = productReviewManager.CountProductId(reviewList);
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// test method to retreive only id and review using select
        /// </summary>
        [TestMethod]
        public void TestMethodRetrieveProductIdAndReview()
        {
            try
            {
                int actual, expected = 25;
                actual = productReviewManager.RetrieveProductIdAndReview(reviewList);
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// test method to skip  first 5 records
        /// </summary>
        [TestMethod]
        public void TestMethodForSkipFirst5Records()
        {
            try
            {
                int actual, expected = 20;
                actual = productReviewManager.SkipRecords(reviewList);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// test method to skip 5 records
        /// </summary>
        [TestMethod]
        public void TestMethodCreateDatatable()
        {
            try
            {
                productReviewManager.CreateDataTable(reviewList);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Test method retreive only records where is like is true
        /// </summary>
        [TestMethod]
        public void TestMethodRetreiveBasedOnIsLike()
        {
            try
            {
                int actual, expected = 15;
                actual = productReviewManager.RetreiveProducIfIsLikeTrue(reviewList);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Method to retreive average rating of each product
        /// </summary>
        [TestMethod]
        public void TestMethodAverageRating()
        {
            try 
            {
                int actual, expected = 12;
                actual = productReviewManager.AverageRating(reviewList);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Test method retreive only rating contains good
        /// </summary>
        [TestMethod]
        public void TestMethodRetreiveGoodRatings()
        {
            try
            {
                int actual, expected = 10;
                actual = productReviewManager.RetreiveGoodRatings(reviewList);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
