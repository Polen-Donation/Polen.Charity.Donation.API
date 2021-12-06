using System.Net.Http;
using System.Threading.Tasks;

namespace Polen.Charity.Donation.Api
{
  public class Transaction
  {
    private string api_token;
    static readonly HttpClient client = new HttpClient();

    public Transaction(string token)
    {
      api_token = token;
    }
    
    public async Task<string> UpdateTransaction(string storeId, string orderId, int status)
    {
      string updateTransaction = null;
      
      HttpResponseMessage response = await client.PostAsync($"https://api.polen.com.br/api/v2/transaction/update/status?api_token={api_token}&storeId={storeId}&orderId={orderId}&status={status}", null);
      if (response.IsSuccessStatusCode)
      {
        updateTransaction = await response.Content.ReadAsStringAsync();
      }
      return updateTransaction;
    }
  }
}