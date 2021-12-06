using System.Net.Http;
using System.Threading.Tasks;

namespace Polen.Charity.Donation.Api
{
  public class Platform
  {
    private string api_token;
    static readonly HttpClient client = new HttpClient();
    public Platform(string token)
    {
      api_token = token;
    }

    public async Task<string> GetPlatform(int page = 0, int pageSize = 100)
    {
      string platform = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/platform/list?api_token={api_token}&page={page}&pageSize={pageSize}");
      if (response.IsSuccessStatusCode)
      {
        platform = await response.Content.ReadAsStringAsync();
      }
      return platform;
    }
  }
}