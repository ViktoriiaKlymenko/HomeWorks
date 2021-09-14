using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace WebApplicationFoodService.Filters
{
    public class ProductExceptionFilter : ExceptionFilterAttribute
    {
        private readonly ILogger<ProductExceptionFilter> _logger;

        public ProductExceptionFilter(ILogger<ProductExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext filterContext, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                filterContext.ExceptionHandled = true;
                _logger.LogError($"{DateTime.Now}: Exception {filterContext.Exception.Message}.");
            }

            if (env.IsEnvironment("QA"))
            {
                filterContext.ExceptionHandled = true;
                _logger.LogError($"{DateTime.Now}: Exception {filterContext.Exception.Message} occurs. {filterContext.Exception.StackTrace}");
            }         
        }
    }
}
