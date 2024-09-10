namespace OneReview.OverServices.Payments;

public interface IPaymentService
{
    void ProcessPayment(decimal amount); 
}
