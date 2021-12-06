using System.Net.Http;
using System.Threading.Tasks;

namespace Polen.Charity.Donation.Api
{
  public class Cause
  {
    private string api_token;
    public Cause(string token)
    {
      api_token = token;
    }
    static readonly HttpClient client = new HttpClient();
    public async Task<string> GetAllCauses(int page=0, int pageSize=100)
    {
      string allCauses = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/cause/all?api_token={api_token}&page={page}&pageSize={pageSize}");
      if (response.IsSuccessStatusCode)
      {
        allCauses = await response.Content.ReadAsStringAsync();
      }
      return allCauses;
    }
    
    public async Task<string> GetCategories(int page=0, int pageSize=20)
    {
      string categories = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/cause/categories?api_token={api_token}&page={page}&pageSize={pageSize}");
      if (response.IsSuccessStatusCode)
      {
        categories = await response.Content.ReadAsStringAsync();
      }
      return categories;
    }
    
    public async Task<string> GetOwnCauses(string storeId, bool onlySelected = false, string city = "", string state = "")
    {
      string ownCauses = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/cause?api_token={api_token}&storeId={storeId}&city={city}&state={state}");
      if (response.IsSuccessStatusCode)
      {
        ownCauses = await response.Content.ReadAsStringAsync();
      }
      return ownCauses;
    }
  }
}