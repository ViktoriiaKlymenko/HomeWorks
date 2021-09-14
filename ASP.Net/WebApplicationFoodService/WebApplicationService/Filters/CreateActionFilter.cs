using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace WebApplicationFoodService.Filters
{
    public class CreateActionFilter : IActionFilter
    {
        private readonly ILogger<CreateActionFilter> _logger;

        public CreateActionFilter(ILogger<CreateActionFilter> logger)
        {
            _logger = logger;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            return;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var RequestBody = string.Empty;

            try
            {
                context.HttpContext.Request.EnableBuffering();
                context.HttpContext.Request.Body.Position = 0;

                using (var reader = new StreamReader(context.HttpContext.Request.Body))
                {
                    RequestBody = reader.ReadToEnd();
                    _logger.LogInformation($"{DateTime.Now}: {RequestBody}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
