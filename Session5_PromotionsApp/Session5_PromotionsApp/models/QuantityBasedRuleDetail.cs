using System;
using System.Collections.Generic;

namespace Session5_PromotionsApp.models;

public partial class QuantityBasedRuleDetail
{
    public int RuleId { get; set; }

    public int? PromotionId { get; set; }

    public int MinQuantity { get; set; }

    public decimal DiscountValue { get; set; }

    public virtual Promotion? Promotion { get; set; }
}
