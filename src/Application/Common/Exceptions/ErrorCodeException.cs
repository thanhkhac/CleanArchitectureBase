using FluentValidation.Results;

namespace CleanArchitectureBase.Application.Common.Exceptions;

public class ErrorCodeException : Exception
{
    public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
    public IDictionary<string, string[]> ValidationErrors { get; set; } = new Dictionary<string, string[]>();


    public ErrorCodeException(string errorCode)
    {
        Errors[errorCode] = new[] { $"Error occurred with code: {errorCode}" };
    }

    public ErrorCodeException(string errorCode, string message)
        : base(message)
    {
        Errors[errorCode] = new[] { message };
    }

    public ErrorCodeException(IEnumerable<(string ErrorCode, string Message)> errors)
    {
        Errors = errors
            .GroupBy(e => e.ErrorCode)
            .ToDictionary(
                g => g.Key,
                g => g.Select(e => e.Message).ToArray()
            );
    }

    public ErrorCodeException(IEnumerable<ValidationFailure> validationFailures)
    {
        ValidationErrors = validationFailures
            .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }
}
