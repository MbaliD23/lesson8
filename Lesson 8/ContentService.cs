using System.Net.Http;
using System.Threading.Tasks;

public class ContentService
{
    private readonly HttpClient _httpClient = new HttpClient();

    public async Task<string> GetWebsiteContentAsync(string url)
    {
        // This can throw if network is down / DNS fails / blocked internet etc.
        return await _httpClient.GetStringAsync(url);
    }
}