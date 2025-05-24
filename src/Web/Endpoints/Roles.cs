
using CleanArchitectureBase.Application.Security.Queries;

namespace CleanArchitectureBase.Web.Endpoints;


public class Roles : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet("/permission-groups", GetPermissionGroups)
            .WithName("Roles")
            .WithOpenApi();
    }

    public async Task<List<PermissionGroupDto>> GetPermissionGroups(ISender sender)
    {
        return await sender.Send(new GetPermissionGroupsQuery());
    }
}
