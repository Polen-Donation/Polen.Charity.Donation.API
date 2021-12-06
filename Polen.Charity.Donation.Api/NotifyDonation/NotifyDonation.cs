using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Polen.Charity.Donation.Api
{
  public class NotifyDonation
  {
    private string api_token;
    static readonly HttpClient client = new HttpClient();

    public NotifyDonation(string token)
    {
      api_token = token;
    }

    public async Task<string> GetNotifyDonationDetails(string storeId, string polenTransactionId="", string orderId="")
    {
      string notifyDonationDetails = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/donation/notify/detail?api_token={api_token}&storeId={storeId}&polenTransactionId={polenTransactionId}&orderId={orderId}");
      if (response.IsSuccessStatusCode)
      {
        notifyDonationDetails = await response.Content.ReadAsStringAsync();
      }
      return notifyDonationDetails;
    }
    
    public async Task<string> GetNotifyDonationList(string storeid, int page=0, int pageSize=20, string startDate="", string endDate="", string userId="", string ngoId="")
    {
      string notifyDonationList = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/donation/notify/list?api_token={api_token}&storeId={storeid}&page={page}&pageSize={pageSize}&startDate={startDate}&endDate={endDate}&userId={userId}&ngoId={ngoId}");
      if (response.IsSuccessStatusCode)
      {
        notifyDonationList = await response.Content.ReadAsStringAsync();
      }
      return notifyDonationList;
    }
    
    public async Task<string> UpdateNotifyDonation(string storeId, NotifyDonationUpdate notifyDonation)
    {
      string updateNotifyDonation = null;
      var data = JsonConvert.SerializeObject(notifyDonation);
      var content = new StringContent(data, Encoding.UTF8, "application/json");

      HttpResponseMessage response = await client.PutAsync($"https://api.polen.com.br/api/v2/donation/notify/update?api_token={api_token}&storeId={storeId}", content);
      if (response.IsSuccessStatusCode)
      {
        updateNotifyDonation = await response.Content.ReadAsStringAsync();
      }
      return updateNotifyDonation;
    }
    
    public async Task<string> CreateNotifyDonation(string storeId, string companyId, NotifyDonationModel notifyDonation)
    {
      string createNotifyDonation = null;
      var data = JsonConvert.SerializeObject(notifyDonation);
      var content = new StringContent(data, Encoding.UTF8, "application/json");

      HttpResponseMessage response = await client.PostAsync($"https://api.polen.com.br/api/v2/donation/notify/create?api_token={api_token}&storeId={storeId}&companyId={companyId}", content);
      if (response.IsSuccessStatusCode)
      {
        createNotifyDonation = await response.Content.ReadAsStringAsync();
      }
      return createNotifyDonation;
    }
  }
}