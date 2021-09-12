using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFoodService.Filters
{
    public class CreateActionFilter : IActionFilter
    {
        private readonly ILogger<CreateActionFilter> _logger;
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Request.EnableBuffering();
            context.HttpContext.Request.Body.Position = 0;
            _logger.LogInformation($"{context.HttpContext.Request.Body}");
        }
    }
}
