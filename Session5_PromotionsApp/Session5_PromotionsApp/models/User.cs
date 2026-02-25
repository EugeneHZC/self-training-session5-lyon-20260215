using System;
using System.Collections.Generic;

namespace Session5_PromotionsApp.models;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public bool MailingListSubscription { get; set; }

    public string ProfilePicture { get; set; } = null!;

    public string SecurityAnswer { get; set; } = null!;

    public int SecQueId { get; set; }

    public string PreferredDeliveryMethod { get; set; } = null!;

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
