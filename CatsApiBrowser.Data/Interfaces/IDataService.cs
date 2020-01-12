using System.Collections.Generic;
using CatsApiBrowser.Data.Models;

namespace CatsApiBrowser.Data.Interfaces
{
    public interface IDataService
    {
        IEnumerable<CategoryModel> GetCategoriesList();
        IEnumerable<ImageModel> GetImages(string category);
        IEnumerable<ImageModel> GetImages(string format, string resultsPerPage, string category);
    }
}
