using CatsApiBrowser.Data.Business;
using CatsApiBrowser.Data.Interfaces;

namespace CatsApiBrowser.Data
{
    public static class DataServiceBuilder
    {
        public static IDataService CreateDataService()
        {
            var api = new ApiWrapper();
            var parser = new XmlApiResponseParser();
            var ds = new DataService(api, parser);
            return ds;
        }

        public static IDataService CreateMockedDataService()
        {
            return new MockedDataService();
        }
    }
}
