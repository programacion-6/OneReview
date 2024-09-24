namespace OneReview.Helpers;

using FluentValidation.Results;
using OneReview.Models;

public static class Converters
{
    public static ValidationResponse ToValidationResponse(this ValidationFailure input)
    {
        return new ValidationResponse
        {
            AttemptedValue = input.AttemptedValue,
            ErrorMessage = input.ErrorMessage,
            PropertyName = input.PropertyName,
        };
    }
}
