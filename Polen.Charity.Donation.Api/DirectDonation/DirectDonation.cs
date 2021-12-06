using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Polen.Charity.Donation.Api
{
  public class DirectDonation
  {
    private string api_token;
    static readonly HttpClient client = new HttpClient();
    public DirectDonation(string token)
    {
      api_token = token;
    }
    
    public async Task<string> CreateDirectDonation(DirectDonationModel donation)
    {
      string CreateDirectDonation = null;
      var data = JsonConvert.SerializeObject(donation);
      var content = new StringContent(data, Encoding.UTF8, "application/json");

      HttpResponseMessage response = await client.PostAsync($"https://api.polen.com.br/api/v2/donation/direct?api_token={api_token}", content);
      if (response.IsSuccessStatusCode)
      {
        CreateDirectDonation = await response.Content.ReadAsStringAsync();
      }
      return CreateDirectDonation;
    }
  }
}