using System;
using System.Threading.Tasks;
using Xunit;

namespace Polen.Charity.Donation.Api.Testing
{
  public class PolenTest
  {
    
    //30cc3743-a457-43ac-aa7c-a2bf7cdf674a storeId
    //36f222b4-57c1-418f-a4e9-4f96c5dd1f76 companyId
    
    public static string token_test = "9bb01c21-d331-4ad4-9dbc-9dedd27481a6";
    private PolenApi PolenApi = new PolenApi(token_test);


    //Cause
    
    [Theory]
    [InlineData(0,20)]
    public async Task Get_causes_success(int page, int pageSize)
    {
      var actionResult = await PolenApi.Cause.GetAllCauses(page, pageSize);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }

    [Theory]
    [InlineData(0, 20)]
    public async Task Get_categories_success(int page, int pageSize)
    {
      var actionResult = await PolenApi.Cause.GetCategories(page, pageSize);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    [Theory]
    [InlineData("30cc3743-a457-43ac-aa7c-a2bf7cdf674a", false, "Curitiba", "PR")]
    [InlineData("30cc3743-a457-43ac-aa7c-a2bf7cdf674a", true, "", "")]
    public async Task Get_own_causes_success(string storeId, bool onlySelected, string city, string state)
    {
      var actionResult = await PolenApi.Cause.GetOwnCauses(storeId, onlySelected, city, state);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    //Company
    
    [Theory]
    [InlineData("36f222b4-57c1-418f-a4e9-4f96c5dd1f76")]
    public async Task Get_company_details_success(string companyId)
    {
      var actionResult = await PolenApi.Company.GetCompanyDetails(companyId);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    [Theory]
    [InlineData(0, 20)]
    public async Task Get_company_list_success(int page, int pageSize)
    {
      var actionResult = await PolenApi.Company.GetCompanyList(page, pageSize);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    [Theory]
    [InlineData("36f222b4-57c1-418f-a4e9-4f96c5dd1f76")]
    public async Task Get_company_stores_success(string companyId)
    {
      var actionResult = await PolenApi.Company.GetCompanyStores(companyId);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    [Theory]
    [InlineData("36f222b4-57c1-418f-a4e9-4f96c5dd1f76")]
    public async Task Put_update_company_success(string companyId)
    {
      CompanyModel companyModel = new CompanyModel();
    
      companyModel.Document = "72.634.998/0001-97";
      companyModel.Name = "Polen Sandbox";
      companyModel.Logo = "";
      companyModel.Segment = "";
      companyModel.Url = "polensandbox.com";
      
      var actionResult = await PolenApi.Company.UpdateCompany(companyId, companyModel);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    [Fact]
    public async Task Post_create_company_success()
    {
      CompanyModel companyModel = new CompanyModel();
    
      companyModel.Document = "01685303250";
      companyModel.Name = "Teste SDK Company";
      companyModel.Logo = "";
      companyModel.Segment = "";
      companyModel.Url = "teste.com";
      
      var actionResult = await PolenApi.Company.CreateCompany(companyModel);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    //DirectDonation
    
    [Fact]
    public async Task Post_create_direct_donation_success()
    {
      DirectDonationModel directDonationModel = new DirectDonationModel();
      
      Causes causes = new Causes();
      causes.Donation = 1;
      causes.CauseId = "cufa";

      Donor donor = new Donor();
      donor.Document = "01685303250";
      donor.Email = "jeovanearaujo@outlook.com";
      donor.Gender = "male";
      donor.Name = "Jeovane Araujo";
      donor.Phone = "41998916810";
      donor.BirthDate = "16/08/1995";
      donor.Verified = false;
      donor.Identifier = "01685303250";
      donor.OptIn = false;

      BankSlipData bankSlipData = new BankSlipData();
      bankSlipData.DueDate = 1;
      bankSlipData.PaymentSystem = 5;

      directDonationModel.Address = null;
      directDonationModel.Causes = new Causes[] {causes};
      directDonationModel.PaymentMethod = 2;
      directDonationModel.CreditCardData = null;
      directDonationModel.Donor = donor;
      directDonationModel.OrderId = "JEO12345678";
      directDonationModel.StoreId = "30cc3743-a457-43ac-aa7c-a2bf7cdf674a";
      directDonationModel.ChildStoreId = null;
      directDonationModel.IsTest = true;
      directDonationModel.CampaignId = null;
      directDonationModel.BankFeeCovered = 0;
      directDonationModel.HasMatchFunding = false;
      directDonationModel.MatchingDonation = 0;
      directDonationModel.BankSlipData = bankSlipData;
      directDonationModel.Notes = "";
      
      var actionResult = await PolenApi.DirectDonation.CreateDirectDonation(directDonationModel);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    //Finance
    [Theory]
    [InlineData("30cc3743-a457-43ac-aa7c-a2bf7cdf674a")]
    public async Task Get_billing_success(string storeId)
    {
      var actionResult = await PolenApi.Finance.GetBilling(storeId);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    
    //NotifyDonation
    [Fact]
    public async Task Get_notify_donation_details_success()
    {
      PolenApi polenApiDetail = new PolenApi("3bb9af43-8120-41c0-ae69-f3a4de223a81");
      var actionResult = await polenApiDetail.NotifyDonation.GetNotifyDonationDetails("720d4121-0af9-4e3d-b55c-e7c6f0729a35", null, "1181982467316");
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    [Theory]
    [InlineData("30cc3743-a457-43ac-aa7c-a2bf7cdf674a")]
    public async Task Get_notify_donation_list_success(string storeId)
    {
      var actionResult = await PolenApi.NotifyDonation.GetNotifyDonationList(storeId);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    [Theory]
    [InlineData("30cc3743-a457-43ac-aa7c-a2bf7cdf674a", "36f222b4-57c1-418f-a4e9-4f96c5dd1f76")]
    public async Task Post_create_notify_donation_success(string storeId, string companyId)
    {
      NotifyDonationModel notifyDonationModel = new NotifyDonationModel();
      notifyDonationModel.OrderId = "TESTEPOLEN123";
      notifyDonationModel.Donation = 1;
      notifyDonationModel.UserDonation = 0;
      notifyDonationModel.UserId = "TESTEUSER123";
      notifyDonationModel.Tags = null;
      notifyDonationModel.StoreName = null;
      notifyDonationModel.StoreUrl = null;
      notifyDonationModel.Currency = null;
      notifyDonationModel.Purchase = 0;
      notifyDonationModel.NgoId = null;
      notifyDonationModel.UserEmail = null;
      notifyDonationModel.UserPhone = null;
      notifyDonationModel.UserDocument = null;
      notifyDonationModel.UserGender = null;
      notifyDonationModel.UserBirthDate = null;
      notifyDonationModel.UserName = null;
      notifyDonationModel.City = null;
      notifyDonationModel.State = null;
      notifyDonationModel.Country = null;
      notifyDonationModel.PaymentMethod = null;
      notifyDonationModel.Notes = null;
      notifyDonationModel.Status = 0;
      notifyDonationModel.CreateAt = null;
      notifyDonationModel.Test = true;

      var actionResult = await PolenApi.NotifyDonation.CreateNotifyDonation(storeId, companyId, notifyDonationModel);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    [Theory]
    [InlineData("30cc3743-a457-43ac-aa7c-a2bf7cdf674a")]
    public async Task Update_notify_donation_success(string storeId)
    {
      NotifyDonationUpdate notifyDonationUpdate = new NotifyDonationUpdate();
      notifyDonationUpdate.OrderId = "TESTEPOLEN123";
      notifyDonationUpdate.Status = 2;
      notifyDonationUpdate.PolenTransactionId = null;
      
      var actionResult = await PolenApi.NotifyDonation.UpdateNotifyDonation(storeId, notifyDonationUpdate);
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }

    //Platform
    [Fact]
    public async Task Get_platform_success()
    {
      var actionResult = await PolenApi.Platform.GetPlatform();
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    //Store
    [Fact]
    public async Task Get_store_detail_success()
    {
      var actionResult = await PolenApi.Store.GetStoreDetail("30cc3743-a457-43ac-aa7c-a2bf7cdf674a");
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
    
    [Fact]
    public async Task Get_store_list_success()
    {
      var actionResult = await PolenApi.Store.GetStoreList();
      var viewResult = Assert.IsType<string>(actionResult);
      Assert.IsAssignableFrom<string>(viewResult);
    }
  }
}

