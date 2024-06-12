using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotanicalBuddy.Core.Services.Botanical;



namespace BotanicalBuddy.Api.Endpoints;

public static class BotanicalEndpoints
{
  public static RouteGroupBuilder MapBotanicalEndpoints(this IEndpointRouteBuilder routes)
  {

    var group = routes.MapGroup("/botanical");
    group.MapGet("/", () =>
      {
        var d = new BotanicalClient();
        var plant = d.GetTestPlant();

        // _logger.LogDebug("Getting Users")
        // var users = await userService.GetAll();
        // _logger.LogDebug("Got Users", users);
        return "here in botanical " + plant;
      });

    return group;


  }
}
