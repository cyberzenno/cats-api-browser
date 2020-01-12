using CatsApiBrowser.Data.Business;
using CatsApiBrowser.Data.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace CatsApiBrowser.UnitTests
{
    [TestClass]
    public class XmlResponseParserFixture
    {
        private readonly IApiResponseParser xmlParser;
        private readonly string CategoriesXmlResponse;
        private readonly string ImagesXmlResponse;

        //SETUP
        public XmlResponseParserFixture()
        {
            xmlParser = new XmlApiResponseParser();
            CategoriesXmlResponse = File.ReadAllText("Resources\\SampleApiCategoriesResponse.xml");
            ImagesXmlResponse = File.ReadAllText("Resources\\SampleApiImagesResponse.xml");
        }

        [TestMethod]
        public void GetCategories()
        {
            //ARRANGE

            //ACT
            var actual = xmlParser.ParseCategoriesList(CategoriesXmlResponse);

            //ASSERT
            Assert.IsTrue(actual.Count() == 3);
        }

        [TestMethod]
        public void GetImages()
        {
            //ARRANGE

            //ACT
            var actual = xmlParser.ParseImagesList(ImagesXmlResponse);

            //ASSERT
            Assert.IsTrue(actual.Count() == 1);
        }
    }
}
