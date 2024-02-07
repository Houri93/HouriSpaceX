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
    public async Task<Capsule[]> GetAllCapsulesAsync()
    {
        return await SendAsync<Capsule[]>(HttpMethod.Get, "capsules");
    }

    public async Task<Company.Company> GetCompanyAsync()
    {
        return await SendAsync<Company.Company>(HttpMethod.Get, "company");
    }

    public async Task<Cores.Core[]> GetAllCoresAsync()
    {
        return await SendAsync<Cores.Core[]>(HttpMethod.Get, "cores");
    }

    public async Task<CrewMember[]> GetAllCrewAsync()
    {
        return await SendAsync<CrewMember[]>(HttpMethod.Get, "crew");
    }

    public async Task<Dragons.Dragon[]> GetAllDragonsAsync()
    {
        return await SendAsync<Dragons.Dragon[]>(HttpMethod.Get, "dragons");
    }
    public async Task<History.History[]> GetAllHistoryAsync()
    {
        return await SendAsync<History.History[]>(HttpMethod.Get, "history");
    }
    public async Task<Launchpads.Launchpad[]> GetAllLandPadsAsync()
    {
        return await SendAsync<Launchpads.Launchpad[]>(HttpMethod.Get, "landpads");
    }
    public async Task<Launches.Launche[]> GetAllLaunchesAsync()
    {
        return await SendAsync<Launches.Launche[]>(HttpMethod.Get, "launches");
    }
    public async Task<Launchpads.Launchpad[]> GetAllLaunchpadsAsync()
    {
        return await SendAsync<Launchpads.Launchpad[]>(HttpMethod.Get, "launchpads");
    }
    public async Task<Payloads.Payload[]> GetAllPayloadsAsync()
    {
        return await SendAsync<Payloads.Payload[]>(HttpMethod.Get, "payloads");
    }
    public async Task<GetRoadsterResponse> GetRoadsterAsync()
    {
        return await SendAsync<GetRoadsterResponse>(HttpMethod.Get, "roadster");
    }
    public async Task<Rockets.Rocket[]> GetAllRocketsAsync()
    {
        return await SendAsync< Rockets.Rocket[]> (HttpMethod.Get, "rockets");
    }
    public async Task<Ships.Ship[]> GetAllShipsAsync()
    {
        return await SendAsync<Ships.Ship[]>(HttpMethod.Get, "ships");
    }
    public async Task<Starlink.StarlinkSatellite[]> GetAllStarlinkSatellitesAsync()
    {
        return await SendAsync<Starlink.StarlinkSatellite[]>(HttpMethod.Get, "starlink");
    }

    private async Task<T> SendAsync<T>(HttpMethod httpMethod, string endpoint)
    {
        var baseUrl = configuration["SpaceXDataBaseUrl"] ?? throw new Exception("SpaceXDataBaseUrl Configuration not found, ie appsettings.json or enviroment variables.");

        var url = $"{baseUrl}{endpoint}";

        using var httpClient = httpClientFactory.CreateClient();
        using var request = new HttpRequestMessage(httpMethod, url);

        var response = await httpClient.SendAsync(request);

        var content = await response.EnsureSuccessStatusCode()
              .Content.ReadFromJsonAsync<T>();
        return content;
    }
}
