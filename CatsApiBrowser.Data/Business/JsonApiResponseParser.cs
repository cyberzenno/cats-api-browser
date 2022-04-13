using CatsApiBrowser.Data.Interfaces;
using CatsApiBrowser.Data.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml;

namespace CatsApiBrowser.Data.Business
{
    public class JsonApiResponseParser : IApiResponseParser
    {
        public IEnumerable<CategoryModel> ParseCategoriesList(string apiResponse)
        {
            var categories = JsonConvert.DeserializeObject<IEnumerable<CategoryModel>>(apiResponse);

            return categories;
        }

        public IEnumerable<ImageModel> ParseImagesList(string apiResponse)
        {
            var images = JsonConvert.DeserializeObject<IEnumerable<ImageModel>>(apiResponse);
      
            return images;
        }
    }
}
