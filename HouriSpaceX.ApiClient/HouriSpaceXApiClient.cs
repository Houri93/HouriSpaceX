using HouriSpaceX.Dtos;

using Microsoft.Extensions.Configuration;

using System.Net.Http.Json;

namespace HouriSpaceX.ApiClient;

public sealed class HouriSpaceXApiClient(IConfiguration configuration, IHttpClientFactory httpClientFactory)
{
    public async Task<CapsuleDto[]> GetAllCapsulesAsync()
    {
        return await SendAsync<CapsuleDto[]>(HttpMethod.Get, "capsules");
    }

    private async Task<T> SendAsync<T>(HttpMethod httpMethod, string endpoint)
    {
        var baseUrl = configuration["ServerApiKey"] ?? throw new Exception("ServerApiKey Configuration not found, ie appsettings.json or enviroment variables.");

        var url = $"{baseUrl}{endpoint}";

        using var httpClient = httpClientFactory.CreateClient();
        using var request = new HttpRequestMessage(httpMethod, url);

        var response = await httpClient.SendAsync(request);

        return await response.EnsureSuccessStatusCode()
              .Content.ReadFromJsonAsync<T>();
    }
}
