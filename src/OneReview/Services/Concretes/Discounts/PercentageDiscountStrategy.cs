﻿using OneReview.Services.DiscountConstants;
using OneReview.Services.Interfaces;

namespace OneReview.Services.Concretes.Discounts;

public class PercentageDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - (totalAmount * DiscountConstants.DefaultIndexDiscount);
    }
}