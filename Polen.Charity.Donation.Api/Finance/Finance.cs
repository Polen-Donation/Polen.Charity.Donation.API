using System.Net.Http;
using System.Threading.Tasks;

namespace Polen.Charity.Donation.Api
{
  public class Finance
  {
    private string api_token;
    static readonly HttpClient client = new HttpClient();

    public Finance(string token)
    {
      api_token = token;
    }

    public async Task<string> GetBilling(string storeid, int page=0, int pageSize=20, string startDate="", string endDate="")
    {
      string getBilling = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/finance/billing/list?api_token={api_token}&storeId={storeid}&page={page}&pageSize={pageSize}&startDate={startDate}&endDate={endDate}");
      if (response.IsSuccessStatusCode)
      {
        getBilling = await response.Content.ReadAsStringAsync();
      }
      return getBilling;
    }
  }
}