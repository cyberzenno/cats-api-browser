using CatsApiBrowser.Data.Interfaces;
using System.Net;

namespace CatsApiBrowser.Data.Business
{
    public class ApiWrapper : IApiWrapper
    {
        public string GetCategoriesList()
        {
            var client = new WebClient();
            var content = client.DownloadString("http://thecatapi.com/api/categories/list");
            return content;
        }

        public string GetImages(string format, string resultsPerPage, string category)
        {
            var url = "http://thecatapi.com/api/images/get?format=" + format + "&results_per_page=" + resultsPerPage + "&category=" + category;
            var client = new WebClient();
            var content = client.DownloadString(url);
            return content;
        }
    }
}
