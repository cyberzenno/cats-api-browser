using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatsApiBrowser.Data.Interfaces;
using CatsApiBrowser.Data;

namespace CatsApiBrowser.UnitTests
{
    [TestClass]
    public class DatasetServiceIntegrationTest
    {
        private IDataService ds;

        //todo: improve integration testing

        //SETUP
        public DatasetServiceIntegrationTest()
        {
            ds = DataServiceBuilder.CreateDataService();
        }

        [TestMethod]
        public void GetCategories()
        {
            //ARRANGE

            //ACT
            var actual = ds.GetCategoriesList();

            //ASSERT
            Assert.IsTrue(actual.Count() > 0);
        }

        [TestMethod]
        public void GetImages()
        {
            //ARRANGE

            //ACT
            var actual = ds.GetImages("hats");

            //ASSERT
            Assert.IsTrue(actual.Count() > 0);
        }

    }
}
