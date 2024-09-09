using OneReview.Domain;

public record ProcessOrderRequest()
{
    public Order ToDomain()
    {
        return new Order();
    }
}