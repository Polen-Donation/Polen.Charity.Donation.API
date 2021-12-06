namespace Polen.Charity.Donation.Api
{
  public class UserUpdateModel
  {
    public string UserId { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string Name { get; set; }
    public string? Document { get; set; }
    public string? Gender { get; set; }
    public string? Birthdate { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? CreateAt { get; set; }
    public bool? Verifed { get; set; }
    public bool? OptIn { get; set; }
  }

  public class UserModel
  {
    public string[]? CauseList { get; set; }
    public string UserId { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string Name { get; set; }
    public string? Document { get; set; }
    public string? Gender { get; set; }
    public string? Birthdate { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? CreateAt { get; set; }
    public bool? Verifed { get; set; }
    public bool? OptIn { get; set; }
  }

  public class UserCauseModel
  {
    public string[] AddCauseList { get; set; }
    public string[] DisableCausesList { get; set; }
  }
}