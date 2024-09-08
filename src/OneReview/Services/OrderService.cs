﻿namespace OneReview.Services;
using OneReview.Services.Discounts;
using OneReview.Services.Payments;
/// <summary>
/// BAD PRACTICES
/// - No es flexible, no es facil extender el codigo, no es facil aumenter mas metodos de pago
/// - Estamos violando el single responsability
/// - encadenamiento largo de else if's
/// - No hay unidades de testeo / Es dificil de testear
/// - Violando el DRY
/// - Violando Open/Closed
/// - (~) Violando el KISS
/// - Violando PoLA
/// 
/// FIXING CODE
/// 1. Aplicar Strategy
/// </summary>
public class OrderService
    {
        private readonly IDiscountStrategy _discountStrategy;
        private readonly IPaymentStrategy _paymentStrategy;

        public OrderService(IDiscountStrategy discountStrategy, IPaymentStrategy paymentStrategy)
        {
            _discountStrategy = discountStrategy;
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessOrder(decimal totalAmount)
        {
            totalAmount = _discountStrategy.ApplyDiscount(totalAmount);

            _paymentStrategy.ProcessPayment(totalAmount);
        }
    }