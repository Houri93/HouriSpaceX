using Microsoft.Extensions.Configuration;

using SpaceXData.ApiClient.Capsules;
using SpaceXData.ApiClient.Company;
using SpaceXData.ApiClient.Cores;
using SpaceXData.ApiClient.Crew;
using SpaceXData.ApiClient.Dragons;
using SpaceXData.ApiClient.History;
using SpaceXData.ApiClient.Landpads;
using SpaceXData.ApiClient.Launches;
using SpaceXData.ApiClient.Launchpads;
using SpaceXData.ApiClient.Payloads;
using SpaceXData.ApiClient.Roadster;
using SpaceXData.ApiClient.Rockets;
using SpaceXData.ApiClient.Ships;
using SpaceXData.ApiClient.Starlink;

using System.Net.Http.Json;

namespace SpaceXData.ApiClient;

public sealed class SpaceXDataApiClient(IConfiguration configuration, IHttpClientFactory httpClientFactory)
{
    public async Task<GetAllCapsulesResponse> GetAllCapsulesAsync()
    {
        return await SendAsync<GetAllCapsulesResponse>(HttpMethod.Get, "capsules");
    }

    public async Task<GetCompanyResponse> GetCompanyAsync()
    {
        return await SendAsync<GetCompanyResponse>(HttpMethod.Get, "company");
    }

    public async Task<GetAllCoresResponse> GetAllCoresAsync()
    {
        return await SendAsync<GetAllCoresResponse>(HttpMethod.Get, "cores");
    }

    public async Task<GetAllCrewResponse> GetAllCrewAsync()
    {
        return await SendAsync<GetAllCrewResponse>(HttpMethod.Get, "crew");
    }

    public async Task<GetAllDragonsResponse> GetAllDragonsAsync()
    {
        return await SendAsync<GetAllDragonsResponse>(HttpMethod.Get, "dragons");
    }
    public async Task<GetAllHistoryResponse> GetAllHistoryAsync()
    {
        return await SendAsync<GetAllHistoryResponse>(HttpMethod.Get, "history");
    }
    public async Task<GetAllLandPadsResponse> GetAllLandPadsAsync()
    {
        return await SendAsync<GetAllLandPadsResponse>(HttpMethod.Get, "landpads");
    }
    public async Task<GetAllLaunchesResponse> GetAllLaunchesAsync()
    {
        return await SendAsync<GetAllLaunchesResponse>(HttpMethod.Get, "launches");
    } 
    public async Task<GetAllLaunchpadsResponse> GetAllLaunchpadsAsync()
    {
        return await SendAsync<GetAllLaunchpadsResponse>(HttpMethod.Get, "launchpads");
    }
    public async Task<GetAllPayloadsResponse> GetAllPayloadsAsync()
    {
        return await SendAsync<GetAllPayloadsResponse>(HttpMethod.Get, "payloads");
    }
    public async Task<GetRoadsterResponse> GetRoadsterAsync()
    {
        return await SendAsync<GetRoadsterResponse>(HttpMethod.Get, "roadster");
    }
    public async Task<GetAllRocketsResponse> GetAllRocketsAsync()
    {
        return await SendAsync<GetAllRocketsResponse>(HttpMethod.Get, "rockets");
    } 
    public async Task<GetAllShipsReponse> GetAllShipsAsync()
    {
        return await SendAsync<GetAllShipsReponse>(HttpMethod.Get, "ships");
    }
    public async Task<GetAllStarlinkSatellitesResponse> GetAllStarlinkSatellitesAsync()
    {
        return await SendAsync<GetAllStarlinkSatellitesResponse>(HttpMethod.Get, "starlink");
    }

    private async Task<T> SendAsync<T>(HttpMethod httpMethod, string endpoint)
    {
        var baseUrl = configuration["SpaceXDataBaseUrl"] ?? throw new Exception("SpaceXDataBaseUrl Configuration not found, ie appsettings.json or enviroment variables.");

        var url = $"{baseUrl}{endpoint}";

        using var httpClient = new HttpClient();
        using var request = new HttpRequestMessage(httpMethod, url);

        var response = await httpClient.SendAsync(request);

        return await response.EnsureSuccessStatusCode()
              .Content.ReadFromJsonAsync<T>();
    }
}
