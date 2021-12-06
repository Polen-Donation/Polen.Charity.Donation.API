using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Polen.Charity.Donation.Api
{
  public class Store
  {
    private string api_token;
    static readonly HttpClient client = new HttpClient();

    public Store(string token)
    {
      api_token = token;
    }

    public async Task<string> GetStoreDetail(string storeId)
    {
      string storeDetail = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/store/detail?api_token={api_token}&storeId={storeId}");
      if (response.IsSuccessStatusCode)
      {
        storeDetail = await response.Content.ReadAsStringAsync();
      }
      return storeDetail;
    }
    
    public async Task<string> GetStoreList(int page = 0, int pageSize = 20)
    {
      string storeList = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/store/list?api_token={api_token}&page={page}&pageSize={pageSize}");
      if (response.IsSuccessStatusCode)
      {
        storeList = await response.Content.ReadAsStringAsync();
      }
      return storeList;
    }
    
    public async Task<string> UpdateStore(string storeId, StoreModel store)
    {
      string updateStore = null;
      var data = JsonConvert.SerializeObject(store);
      var content = new StringContent(data, Encoding.UTF8, "application/json");

      HttpResponseMessage response = await client.PutAsync($"https://api.polen.com.br/api/v2/store/update?api_token={api_token}&storeId={storeId}", content);
      if (response.IsSuccessStatusCode)
      {
        updateStore = await response.Content.ReadAsStringAsync();
      }
      return updateStore;
    }
    
    public async Task<string> AddCause(string storeId, string[] causes)
    {
      string addCause = null;
      var data = JsonConvert.SerializeObject(causes);
      var content = new StringContent(data, Encoding.UTF8, "application/json");

      HttpResponseMessage response = await client.PostAsync($"https://api.polen.com.br/api/v2/store/cause/add?api_token={api_token}&storeId={storeId}", content);
      if (response.IsSuccessStatusCode)
      {
        addCause = await response.Content.ReadAsStringAsync();
      }
      return addCause;
    }
    
    public async Task<string> CreateStore(string companyId, StoreModel store)
    {
      string createStore = null;
      var data = JsonConvert.SerializeObject(store);
      var content = new StringContent(data, Encoding.UTF8, "application/json");

      HttpResponseMessage response = await client.PostAsync($"https://api.polen.com.br/api/v2/store/create?api_token={api_token}&companyId={companyId}", content);
      if (response.IsSuccessStatusCode)
      {
        createStore = await response.Content.ReadAsStringAsync();
      }
      return createStore;
    }
    
    
    public async Task<string> RemoveCause(string storeId, string[] causes)
    {
      string removeCause = null;
      var data = JsonConvert.SerializeObject(causes);
      var content = new StringContent(data, Encoding.UTF8, "application/json");

      HttpResponseMessage response = await client.PostAsync($"https://api.polen.com.br/api/v2/store/cause/remove?api_token={api_token}&storeId={storeId}", content);
      if (response.IsSuccessStatusCode)
      {
        removeCause = await response.Content.ReadAsStringAsync();
      }
      return removeCause;
    }
  }
}