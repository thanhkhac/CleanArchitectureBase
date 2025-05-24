// ReSharper disable InconsistentNaming
namespace CleanArchitectureBase.Domain.Constants;

public static class ErrorCodes
{
    //COMMON
    public const string COMMON_FORBIDDEN = nameof(COMMON_FORBIDDEN);
    public const string COMMON_SERVER_INTERNAL_ERROR = nameof(COMMON_SERVER_INTERNAL_ERROR);
    public const string COMMON_NOT_FOUND = nameof(COMMON_NOT_FOUND);
    public const string COMMON_GONE = nameof(COMMON_GONE);
    public const string COMMON_BAD_REQUEST = nameof(COMMON_BAD_REQUEST);
    public const string COMMON_CONFLICT = nameof(COMMON_CONFLICT);
    public const string COMMON_TIMEOUT_ERROR = nameof(COMMON_TIMEOUT_ERROR);

    //ACCOUNT
    public const string ACCOUNT_NOTFOUND = nameof(ACCOUNT_NOTFOUND);
    public const string ACCOUNT_LOCKED = nameof(ACCOUNT_LOCKED);
    public const string ACCOUNT_BANNED = nameof(ACCOUNT_BANNED);
    public const string ACCOUNT_USERNAME_ALREADY_EXISTS = nameof(ACCOUNT_USERNAME_ALREADY_EXISTS);
    public const string ACCOUNT_EMAIL_ALREADY_EXISTS = nameof(ACCOUNT_EMAIL_ALREADY_EXISTS);
    public const string ACCOUNT_INVALID_PASSWORD = nameof(ACCOUNT_INVALID_PASSWORD);
    public const string ACCOUNT_INVALID_CREDENTIALS = nameof(ACCOUNT_INVALID_CREDENTIALS);
    public const string ACCOUNT_INVALID_VERIFICATION_CODE = nameof(ACCOUNT_INVALID_VERIFICATION_CODE);

}
