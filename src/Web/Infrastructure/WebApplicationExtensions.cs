﻿using System.Reflection;

namespace CleanArchitectureBase.Web.Infrastructure;

//Vai trò: Map các API
public static class WebApplicationExtensions
{
    //Vai trò: ?
    public static RouteGroupBuilder MapGroup(this WebApplication app, EndpointGroupBase group)
    {
        var groupName = group.GetType().Name;

        return app
            .MapGroup($"/api/{groupName}")
            .WithGroupName(groupName)
            .WithTags(groupName)
            .WithOpenApi();
    }
    
    //Vai trò: Tìm các class kế thừa từ EndpointGroupBase và gọi hàm Map của EndpointGroupBase
    //Hàm Map của EndpointGroupBase sẽ gọi tới hàm MapGroup (ở trên)
    public static WebApplication MapEndpoints(this WebApplication app)
    {
        var endpointGroupType = typeof(EndpointGroupBase);

        var assembly = Assembly.GetExecutingAssembly();

        var endpointGroupTypes = assembly.GetExportedTypes()
            .Where(t => t.IsSubclassOf(endpointGroupType));

        foreach (var type in endpointGroupTypes)
        {
            if (Activator.CreateInstance(type) is EndpointGroupBase instance)
            {
                instance.Map(app);
            }
        }

        return app;
    }
}
