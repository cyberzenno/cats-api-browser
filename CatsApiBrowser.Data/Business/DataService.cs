using CatsApiBrowser.Data.Interfaces;
using CatsApiBrowser.Data.Models;
using System.Collections.Generic;

namespace CatsApiBrowser.Data.Business
{
    public class DataService : IDataService
    {
        private readonly IApiWrapper Api;
        private readonly IApiResponseParser ApiResponseParser;

        public DataService(IApiWrapper apiWrapper, IApiResponseParser apiResponseParser)
        {
            Api = apiWrapper;
            ApiResponseParser = apiResponseParser;
        }

        public IEnumerable<CategoryModel> GetCategoriesList()
        {
            var response = Api.GetCategoriesList();

            //todo: handle errors
            if (string.IsNullOrWhiteSpace(response)) return null;

            var categories = ApiResponseParser.ParseCategoriesList(response);
            return categories;
        }

        public IEnumerable<ImageModel> GetImages(string format, string resultsPerPage, string category)
        {
            var response = Api.GetImages(format, resultsPerPage, category);

            //todo: handle errors
            if (string.IsNullOrWhiteSpace(response)) return null;

            var images = ApiResponseParser.ParseImagesList(response);
            return images;
        }

        //TODO: think a bit better about IDataService interface
        public IEnumerable<ImageModel> GetImages(string category)
        {
            return GetImages("xml", "10", category);
        }
    }
}
