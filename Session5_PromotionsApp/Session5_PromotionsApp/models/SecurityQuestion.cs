using System;
using System.Collections.Generic;

namespace Session5_PromotionsApp.models;

public partial class SecurityQuestion
{
    public int Id { get; set; }

    public string Question { get; set; } = null!;
}
