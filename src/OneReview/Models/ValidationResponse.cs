namespace OneReview.Models;

public class ValidationResponse
{
    public string PropertyName { get; set; }

    public string ErrorMessage { get; set; }

    public string AttemptedValue { get; set; }
}
