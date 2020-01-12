using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatsApiBrowser.Data.Interfaces;
using CatsApiBrowser.Data.Business;

namespace CatsApiBrowser.UnitTests
{
    [TestClass]
    public class ApiWrapperIntegrationTest
    {
        private readonly IApiWrapper apiWrapper;

        //TODO: IMPROVE INTEGRATION TESTS

        //SETUP
        public ApiWrapperIntegrationTest()
        {
            apiWrapper = new ApiWrapper();
        }

        [TestMethod]
        public void GetCategories()
        {
            //ARRANGE

            //ACT
            var actual = apiWrapper.GetCategoriesList();

            //ASSERT
            Assert.IsTrue(!string.IsNullOrWhiteSpace(actual));
        }

        [TestMethod]
        public void GetImages()
        {
            //ARRANGE

            //ACT
            var actual = apiWrapper.GetImages("xml", "10", "hats");

            //ASSERT
            Assert.IsTrue(!string.IsNullOrWhiteSpace(actual));
        }

    }
}
