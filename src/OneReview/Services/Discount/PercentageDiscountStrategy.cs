﻿using OneReview.Services.Constants;

namespace OneReview.Services;

public class PercentageDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - (totalAmount * DiscountConstants.DefaultIndexDiscount);
    }
}
