using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Polen.Charity.Donation.Api
{
  public class User
  {
    private string api_token;
    static readonly HttpClient client = new HttpClient();

    public User(string token)
    {
      api_token = token;
    }
    
    public async Task<string> GetUserDetails(string storeId, string userId)
    {
      string userDetails = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/user/detail?api_token={api_token}&polenUserId={userId}&storeId={storeId}");
      if (response.IsSuccessStatusCode)
      {
        userDetails = await response.Content.ReadAsStringAsync();
      }
      return userDetails;
    }
    
    public async Task<string> GetUserImpact(string storeId, string userId)
    {
      string userImpact = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/user/impact?api_token={api_token}&userId={userId}&storeId={storeId}");
      if (response.IsSuccessStatusCode)
      {
        userImpact = await response.Content.ReadAsStringAsync();
      }
      return userImpact;
    }
    
    public async Task<string> GetUserList(string storeId, int page=0, int pageSize=20)
    {
      string userList = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/user/impact?api_token={api_token}&page={page}&pageSize={pageSize}");
      if (response.IsSuccessStatusCode)
      {
        userList = await response.Content.ReadAsStringAsync();
      }
      return userList;
    }
    
    public async Task<string> UpdateUser(UserUpdateModel user, string storeId)
    {
      string update = null;
      var data = JsonConvert.SerializeObject(user);
      var content = new StringContent(data, Encoding.UTF8, "application/json");

      HttpResponseMessage response = await client.PutAsync($"https://api.polen.com.br/api/v2/user/update?api_token={api_token}&storeId={storeId}", content);
      if (response.IsSuccessStatusCode)
      {
        update = await response.Content.ReadAsStringAsync();
      }
      return update;
    }
    
    public async Task<string> CreateUser(UserModel user, string storeId)
    {
      string create = null;
      var data = JsonConvert.SerializeObject(user);
      var content = new StringContent(data, Encoding.UTF8, "application/json");

      HttpResponseMessage response = await client.PostAsync($"https://api.polen.com.br/api/v2/user/create?api_token={api_token}&storeId={storeId}", content);
      if (response.IsSuccessStatusCode)
      {
        create = await response.Content.ReadAsStringAsync();
      }
      return create;
    }
    
    public async Task<string> UpdateUserCause(string userId, string storeId, UserCauseModel causes)
    {
      string cause = null;
      var data = JsonConvert.SerializeObject(causes);
      var content = new StringContent(data, Encoding.UTF8, "application/json");

      HttpResponseMessage response = await client.PostAsync($"https://api.polen.com.br/api/v2/user/causes?api_token={api_token}&storeId={storeId}&userId={userId}", content);
      if (response.IsSuccessStatusCode)
      {
        cause = await response.Content.ReadAsStringAsync();
      }
      return cause;
    }
    
    public async Task<string> DeleteUser(string userId, string storeId)
    {
      string cause = null;
      
      HttpResponseMessage response = await client.DeleteAsync($"https://api.polen.com.br/api/v2/user/detail?api_token={api_token}&storeId={storeId}&userId={userId}");
      if (response.IsSuccessStatusCode)
      {
        cause = await response.Content.ReadAsStringAsync();
      }
      return cause;
    }
  }
}