namespace OpenLibrarySearchTesting;

public class RestClient : IDisposable
{
    private readonly HttpClient _client;

    public RestClient(string baseUrl)
    {
        _client = new HttpClient
        {
            BaseAddress = new Uri(baseUrl),
            Timeout = TimeSpan.FromSeconds(50)
        };
    }s

    internal string HttpGet(string path)
    {
        var resp = _client.GetAsync(path);
        var result = resp.Result;
        result.EnsureSuccessStatusCode();
        return result.Content.ReadAsStringAsync().Result;
    }

    public void Dispose()
    {
        _client.Dispose();
    }
}