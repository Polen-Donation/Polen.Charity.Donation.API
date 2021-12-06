namespace Polen.Charity.Donation.Api
{
  public class Donor
  {
    public string Identifier { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Document { get; set; }
    public string Gender { get; set; }
    public string BirthDate { get; set; }
    public bool Verified { get; set; }
    public bool OptIn { get; set; }
  }

  public class CreditCardData
  {
    public int PaymentSystem { get; set; }
    public string FullName { get; set; }
    public string CardNumber { get; set; }
    public string ExpirationDate { get; set; }
    public string SecurityCode { get; set; }
    public int InstallmentQuantity { get; set; }
  }

  public class BankSlipData
  {
    public int PaymentSystem { get; set; }
    public int DueDate { get; set; }
  }

  public class Address
  {
    public string ZipCode { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }
    public string Complement { get; set; }
    public string District { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
  }

  public class Causes
  {
    public string CauseId { get; set; }
    public float Donation { get; set; } 
  }
  
  public class DirectDonationModel
  {
    public string StoreId { get; set; }
    public string ChildStoreId { get; set; }
    public string IsTest { get; set; }
    public string CampaignId { get; set; }
    public int PaymentMethod { get; set; }
    public string OrderId { get; set; }
    public float BankFeeCovered { get; set; }
    public bool HasMatchFunding { get; set; }
    public float MatchingDonation { get; set; }
    public string Notes { get; set; }
    public Donor Donor { get; set; }
    public CreditCardData CreditCardData { get; set; }
    public BankSlipData BankSlipData { get; set; }
    public Address Address { get; set; }
    public Causes[] Causes { get; set; }
  }
}