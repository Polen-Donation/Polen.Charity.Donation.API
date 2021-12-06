using System.Net.Http;
using System.Threading.Tasks;

namespace Polen.Charity.Donation.Api
{
  public class Transparency
  {
    private string api_token;
    static readonly HttpClient client = new HttpClient();

    public Transparency(string token)
    {
      api_token = token;
    }

    public async Task<string> GetConsolidatedImpact(string storeId)
    {
      string consolidatedImpact = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/transparency/impact/consolidated?api_token={api_token}&storeId={storeId}");
      if (response.IsSuccessStatusCode)
      {
        consolidatedImpact = await response.Content.ReadAsStringAsync();
      }
      return consolidatedImpact;
    }
    
    public async Task<string> GetContentDetail(string storeId, string identifier)
    {
      string contentDetail = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/transparency/content/detail?api_token={api_token}&storeId={storeId}&identifier={identifier}");
      if (response.IsSuccessStatusCode)
      {
        contentDetail = await response.Content.ReadAsStringAsync();
      }
      return contentDetail;
    }
    
    public async Task<string> GetReceipts(string storeId, string causeId, string startDate="", string endDate="")
    {
      string receipts = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/transparency/receipts?api_token={api_token}&storeId={storeId}&causeId={causeId}&startDate={startDate}&endDate={endDate}");
      if (response.IsSuccessStatusCode)
      {
        receipts = await response.Content.ReadAsStringAsync();
      }
      return receipts;
    }
    
    public async Task<string> GetContentList(string storeId, string causeId, string startDate="", string endDate="")
    {
      string contentList = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/transparency/content/list?api_token={api_token}&storeId={storeId}&causeId={causeId}&startDate={startDate}&endDate={endDate}");
      if (response.IsSuccessStatusCode)
      {
        contentList = await response.Content.ReadAsStringAsync();
      }
      return contentList;
    }
  }
}