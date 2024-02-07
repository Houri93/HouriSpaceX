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
    
    public async Task<CompanyDto> GetCompanyAsync()
    {
        return await SendAsync<CompanyDto>(HttpMethod.Get, "company");
    }

 

    private async Task<T> SendAsync<T>(HttpMethod httpMethod, string endpoint)
    {
        var baseUrl = configuration["ServerApiBaseUrl"] ?? throw new Exception("ServerApiBaseUrl Configuration not found, ie appsettings.json or enviroment variables.");
        var apiKey = configuration["ServerApiKey"] ?? throw new Exception("ServerApiKey Configuration not found, ie appsettings.json or enviroment variables.");

        var url = $"{baseUrl}{endpoint}";

        using var httpClient = httpClientFactory.CreateClient();
        using var request = new HttpRequestMessage(httpMethod, url);
        request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", apiKey);

        var response = await httpClient.SendAsync(request);

        return await response.EnsureSuccessStatusCode()
              .Content.ReadFromJsonAsync<T>();
    }
}
