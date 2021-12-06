namespace Polen.Charity.Donation.Api
{
  public class PolenApi
  {
    public Cause Cause;
    public Company Company;
    public DirectDonation DirectDonation;
    public Finance Finance;
    public Platform Platform;
    public NotifyDonation NotifyDonation;
    public Transaction Transaction;
    public Store Store;
    
    public PolenApi(string token)
    {
      Cause = new Cause(token);
      Company = new Company(token);
      DirectDonation = new DirectDonation(token);
      Finance = new Finance(token);
      Platform = new Platform(token);
      NotifyDonation = new NotifyDonation(token);
      Transaction = new Transaction(token);
      Store = new Store(token);
    }
  }
}