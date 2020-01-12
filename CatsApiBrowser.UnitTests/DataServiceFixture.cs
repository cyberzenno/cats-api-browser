using CatsApiBrowser.Data.Business;
using CatsApiBrowser.Data.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Moq;
using CatsApiBrowser.Data.Models;

namespace CatsApiBrowser.UnitTests
{
    [TestClass]
    public class DataServiceFixture
    {
        private readonly string CategoriesXmlResponse;
        private readonly string ImagesXmlResponse;

        private readonly Mock<IApiWrapper> _mApiWrapper;
        private readonly Mock<IApiResponseParser> _mXmlParser;

        private readonly IDataService _dataService;

        //SETUP
        public DataServiceFixture()
        {
            _mApiWrapper = new Mock<IApiWrapper>();
            _mXmlParser = new Mock<IApiResponseParser>();
            _dataService = new DataService(_mApiWrapper.Object, _mXmlParser.Object);

            //mock some results
            var categories = new List<CategoryModel>()
            {
                new CategoryModel(){Id = "1",Name = "one"},
                new CategoryModel(){Id = "2",Name = "two"},
            };

            var images = new List<ImageModel>()
            {
                new ImageModel(){Id = "1",Url="url_1",SourceUrl="source_1"},
                new ImageModel(){Id = "2",Url="url_2",SourceUrl="source_2"}
            };

            //mock used methods
            _mApiWrapper.Setup(x => x.GetCategoriesList()).Returns("<foo></foo>");
            _mApiWrapper.Setup(x => x.GetImages(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns("<foo></foo>");

            _mXmlParser.Setup(x => x.ParseCategoriesList(It.IsAny<string>())).Returns(categories);
            _mXmlParser.Setup(x => x.ParseImagesList(It.IsAny<string>())).Returns(images);
        }

        [TestMethod]
        public void GetCategories()
        {
            //ARRANGE

            //ACT
            var actual = _dataService.GetCategoriesList();

            //ASSERT
            Assert.IsTrue(actual.Count() == 2);

        }

        [TestMethod]
        public void GetCategories_Null()
        {
            //ARRANGE
            _mApiWrapper.Setup(x => x.GetCategoriesList()).Returns(string.Empty);

            //ACT
            var actual = _dataService.GetCategoriesList();

            //ASSERT
            Assert.IsNull(actual);
        }


        [TestMethod]
        public void Getimages()
        {
            //ARRANGE

            //ACT
            var actual = _dataService.GetImages("foo");

            //ASSERT
            Assert.IsTrue(actual.Count() == 2);

        }

        [TestMethod]
        public void Getimages_Null()
        {
            //ARRANGE
            _mApiWrapper.Setup(x => x.GetImages(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(string.Empty);

            //ACT
            var actual = _dataService.GetImages("bar");

            //ASSERT
            Assert.IsNull(actual);
        }
    }
}
