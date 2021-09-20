using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFoodService.Filters
{
    public class CreateActionFilter : ActionFilterAttribute
    {
        private readonly ILogger<CreateActionFilter> _logger;

        public CreateActionFilter(ILogger<CreateActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var requestBody = string.Empty;

            try
            {
                context.HttpContext.Request.EnableBuffering();
                context.HttpContext.Request.Body.Position = 0;

                using (var reader = new StreamReader(context.HttpContext.Request.Body))
                {
                    requestBody = reader.ReadToEnd();
                    _logger.LogInformation($"{DateTime.Now}: {requestBody}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }
    }
}
