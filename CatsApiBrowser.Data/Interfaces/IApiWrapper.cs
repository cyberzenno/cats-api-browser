namespace CatsApiBrowser.Data.Interfaces
{
    public interface IApiWrapper
    {
        string GetCategoriesList();
        string GetImages(string format, string resultsPerPage, string category);
    }
}
