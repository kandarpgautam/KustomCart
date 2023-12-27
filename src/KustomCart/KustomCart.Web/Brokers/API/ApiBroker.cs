using RESTFulSense.WebAssembly.Clients;

namespace KustomCart.Web.Brokers.API
{
    public class ApiBroker : IApiBroker
    {
        public ApiBroker(IRESTFulApiFactoryClient apiClient)
        {
            ApiClient = apiClient;
        }

        public IRESTFulApiFactoryClient ApiClient { get; }

        private async ValueTask<T> GetAsync<T>(string relativeUrl) => 
            await this.ApiClient.GetContentAsync<T>(relativeUrl);

        private async ValueTask<T> PostAsync<T>(string relativeUrl, T content) => 
            await this.ApiClient.PostContentAsync<T>(relativeUrl, content);

        private async ValueTask<T> PutAsync<T>(string relativeUrl, T content) =>
            await this.ApiClient.PutContentAsync<T>(relativeUrl, content);

        private async ValueTask<T> DeleteAsync<T>(string relativeUrl) =>
            await this.ApiClient.DeleteContentAsync<T>(relativeUrl);
    }
}
