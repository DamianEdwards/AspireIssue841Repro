namespace AspireIssue841Repro.Web;

public class AdminApiClient(HttpClient httpClient)
{
    public HttpClient HttpClient { get; } = httpClient;

    public async Task<int> GetApi1()
    {
        var response = await HttpClient.GetAsync("/api1");
        return await response.Content.ReadFromJsonAsync<int>();
    }

    public async Task<int> GetApi2()
    {
        var response = await HttpClient.GetAsync("/api2");
        return await response.Content.ReadFromJsonAsync<int>();
    }

    public async Task<int> GetApi3()
    {
        var response = await HttpClient.GetAsync("/api3");
        return await response.Content.ReadFromJsonAsync<int>();
    }

    public async Task<int> GetApi4()
    {
        var response = await HttpClient.GetAsync("/api4");
        return await response.Content.ReadFromJsonAsync<int>();
    }
}
