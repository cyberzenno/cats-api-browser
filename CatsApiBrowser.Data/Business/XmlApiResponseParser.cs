using CatsApiBrowser.Data.Interfaces;
using CatsApiBrowser.Data.Models;
using System.Collections.Generic;
using System.Xml;

namespace CatsApiBrowser.Data.Business
{
    public class XmlApiResponseParser : IApiResponseParser
    {
        public IEnumerable<CategoryModel> ParseCategoriesList(string apiResponse)
        {
            XmlDocument document = new XmlDocument();
            document.LoadXml(apiResponse);

            // Select a list of nodes
            XmlNodeList nodes = document.SelectNodes("response/data/categories/category");

            //TODO: IMPLEMENT THE DIRTY PARSING WITH A DECENT XML DESERIALIZER
            //DIRTY PARSING
            var categories = new List<CategoryModel>();
            foreach (XmlNode node in nodes)
            {
                var category = new CategoryModel();
                category.Id = node.ChildNodes[0].InnerText;
                category.Name = node.ChildNodes[1].InnerText;

                categories.Add(category);
            }

            return categories;
        }

        public IEnumerable<ImageModel> ParseImagesList(string apiResponse)
        {
            XmlDocument document = new XmlDocument();
            document.LoadXml(apiResponse);

            // Select a list of nodes
            XmlNodeList nodes = document.SelectNodes("response/data/images/image");

            var images = new List<ImageModel>();
            foreach (XmlNode node in nodes)
            {
                var image = new ImageModel();
                image.Id = node.ChildNodes[0].InnerText;
                image.Url = node.ChildNodes[1].InnerText;
                image.SourceUrl = node.ChildNodes[2].InnerText;

                images.Add(image);
            }

            return images;
        }
    }
}
