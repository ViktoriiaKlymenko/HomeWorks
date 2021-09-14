using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFoodService.Filters
{
    public class GeneralExceptionFilter : ExceptionFilterAttribute
    {
        private readonly ILogger<GeneralExceptionFilter> _logger;

        public GeneralExceptionFilter(ILogger<GeneralExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext filterContext)
        {          
            filterContext.ExceptionHandled = true;
            _logger.LogError($"{DateTime.Now}: Exception {filterContext.Exception.Message} occurs. {filterContext.Exception.StackTrace}");
        }
    }
}
