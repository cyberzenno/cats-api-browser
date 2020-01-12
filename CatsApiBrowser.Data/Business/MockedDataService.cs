using CatsApiBrowser.Data.Interfaces;
using CatsApiBrowser.Data.Models;
using System;
using System.Collections.Generic;

namespace CatsApiBrowser.Data.Business
{
    public class MockedDataService : IDataService
    {
        public IEnumerable<CategoryModel> GetCategoriesList()
        {
            var categories = new List<CategoryModel>()
            {
                new CategoryModel(){Id = "1",Name = "small"},
                new CategoryModel(){Id = "2",Name = "big"},
            };

            return categories;
        }

        public IEnumerable<ImageModel> GetImages(string category)
        {
            var small = new List<ImageModel>()
            {
                new ImageModel(){Id = "1",Url="http://placehold.it/300x300",SourceUrl=""},
                new ImageModel(){Id = "2",Url="http://placehold.it/300x300",SourceUrl=""}
            };

            var big = new List<ImageModel>()
            {
                new ImageModel(){Id = "1",Url="http://placehold.it/600x600",SourceUrl=""},
                new ImageModel(){Id = "2",Url="http://placehold.it/600x600",SourceUrl=""}
            };

            return category == "small" ? small : big;
        }

        public IEnumerable<ImageModel> GetImages(string format, string resultsPerPage, string category)
        {
            throw new NotImplementedException();
        }
    }
}
