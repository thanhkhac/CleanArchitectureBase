namespace Microsoft.Extensions.DependencyInjection.Users.Commands;



public record LoginCommand : IRequest
{
    public int Id { get; init; }

    public string? Title { get; init; }
}

public class LoginCommandHandler : IRequestHandler<LoginCommand>
{

    public Task Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
