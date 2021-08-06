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
    }
}
