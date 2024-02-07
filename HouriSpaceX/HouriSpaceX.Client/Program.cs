using HouriSpaceX.ApiClient;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMudServices();
builder.Services.AddHttpClient();
builder.Services.AddScoped<HouriSpaceXApiClient>();

await builder.Build().RunAsync();
