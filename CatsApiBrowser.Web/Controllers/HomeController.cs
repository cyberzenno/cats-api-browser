using CatsApiBrowser.Data;
using CatsApiBrowser.Data.Interfaces;
using System.Web.Mvc;

namespace CatsApiBrowser.Web.Controllers
{
    public class HomeController : Controller
    {
        IDataService dataService = DataServiceBuilder.CreateDataService();

        public ActionResult Index()
        {
            var categories = dataService.GetCategoriesList();
            return View(categories);
        }

        public ActionResult GetImages(string category)
        {
            //todo: handle exceptions
            var images = dataService.GetImages(category);

            return View(images);
        }

    }
}