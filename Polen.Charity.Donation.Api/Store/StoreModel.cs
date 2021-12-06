namespace Polen.Charity.Donation.Api
{
  public class StoreModel
  {
    public string Email { get; set; }
    public string StoreUrl { get; set; }
    public string StoreName { get; set; }
    public string[] Tags { get; set; }
    public string Domain { get; set; }
    public string NameContact { get; set; }
    public string Phone { get; set; }
    public string Document { get; set; }
    public string Logo { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zipcode { get; set; }
    public string PlatformId { get; set; }
    public bool Test { get; set; }
    public bool Active { get; set; }
  }
}