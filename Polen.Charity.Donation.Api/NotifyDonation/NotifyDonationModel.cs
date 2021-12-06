namespace Polen.Charity.Donation.Api
{
  public class NotifyDonationModel
  {
    public string OrderId { get; set; }
    public float Donation { get; set; }
    public float UserDonation { get; set; }
    public string UserId { get; set; }
    public string[] Tags { get; set; }
    public string StoreName { get; set; }
    public string StoreUrl { get; set; }
    public string Currency { get; set; }
    public float Purchase { get; set; }
    public string NgoId { get; set; }
    public string UserEmail { get; set; }
    public string UserPhone { get; set; }
    public string UserDocument { get; set; }
    public string UserGender { get; set; }
    public string UserBirthDate { get; set; }
    public string UserName { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PaymentMethod { get; set; }
    public string Notes { get; set; }
    public int Status { get; set; }
    public string CreateAt { get; set; }
    public bool Test { get; set; }
  }

  public class NotifyDonationUpdate
  {
    public string PolenTransactionId { get; set; }
    public string OrderId { get; set; }
    public int Status { get; set; }
  }
}