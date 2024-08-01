using Microsoft.AspNetCore.Mvc;

namespace Educar.Backend.Web.Infrastructure;

public abstract class EndpointGroupBase
{
    public abstract void Map(WebApplication app);
}