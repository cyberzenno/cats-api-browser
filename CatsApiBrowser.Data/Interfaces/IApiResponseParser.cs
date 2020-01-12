using CatsApiBrowser.Data.Models;
using System.Collections.Generic;

namespace CatsApiBrowser.Data.Interfaces
{
    public interface IApiResponseParser
    {
        IEnumerable<CategoryModel> ParseCategoriesList(string apiResponse);
        IEnumerable<ImageModel> ParseImagesList(string apiResponse);
    }
}
