using KustomCart.Web;
using KustomCart.Web.Brokers.API;
using KustomCart.Web.Brokers.Logging;
using KustomCart.Web.Models.Configurations;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RESTFulSense.WebAssembly.Clients;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
var configuration = builder.Configuration;

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// common services 
builder.Services.AddScoped<IApiBroker, ApiBroker>(); 
builder.Services.AddHttpClient<IRESTFulApiFactoryClient, RESTFulApiFactoryClient>(ConfigureHttpClient);
builder.Services.AddScoped<ILogger,Logger<LoggingBroker>>();
builder.Services.AddScoped<ILoggingBroker, LoggingBroker> ();

// project specific services
builder.Services.AddKustomCartServices(configuration);

void ConfigureHttpClient(HttpClient httpClient)
{
    LocalConfigurations localConfigurations = configuration.Get<LocalConfigurations>();
    string apiUrl = localConfigurations.ApiConfigurations.Url;
    httpClient.BaseAddress = new Uri(apiUrl);
}

await builder.Build().RunAsync();
