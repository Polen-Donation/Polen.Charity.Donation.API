using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Polen.Charity.Donation.Api
{
  public class Company
  {
    private string api_token;
    public Company(string token)
    {
      api_token = token;
    }
    static readonly HttpClient client = new HttpClient();

    public async Task<string> GetCompanyDetails(string companyId)
    {
      string companyDetails = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/company/detail?api_token={api_token}&companyId={companyId}");
      if (response.IsSuccessStatusCode)
      {
        companyDetails = await response.Content.ReadAsStringAsync();
      }
      return companyDetails;
    }
    
    public async Task<string> GetCompanyList(int page=0, int pageSize=20)
    {
      string companyList = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/company/list?api_token={api_token}&page={page}&pageSize={pageSize}");
      if (response.IsSuccessStatusCode)
      {
        companyList = await response.Content.ReadAsStringAsync();
      }
      return companyList;
    }
    
    public async Task<string> GetCompanyStores(string companyId)
    {
      string companyStores = null;
      HttpResponseMessage response = await client.GetAsync($"https://api.polen.com.br/api/v2/company/stores?api_token={api_token}&companyId={companyId}");
      if (response.IsSuccessStatusCode)
      {
        companyStores = await response.Content.ReadAsStringAsync();
      }
      return companyStores;
    }
    
    public async Task<string> UpdateCompany(string companyId, CompanyModel company)
    {
      string updateCompany = null;
      var data = JsonConvert.SerializeObject(company);
      var content = new StringContent(data, Encoding.UTF8, "application/json");

      HttpResponseMessage response = await client.PutAsync($"https://api.polen.com.br/api/v2/company/update?api_token={api_token}&companyId={companyId}", content);
      if (response.IsSuccessStatusCode)
      {
        updateCompany = await response.Content.ReadAsStringAsync();
      }
      return updateCompany;
    }
    
    public async Task<string> CreateCompany(CompanyModel company)
    {
      string createCompany = null;
      var data = JsonConvert.SerializeObject(company);
      var content = new StringContent(data, Encoding.UTF8, "application/json");

      HttpResponseMessage response = await client.PostAsync($"https://api.polen.com.br/api/v2/company/create?api_token={api_token}", content);
      if (response.IsSuccessStatusCode)
      {
        createCompany = await response.Content.ReadAsStringAsync();
      }
      return createCompany;
    }
  }
}