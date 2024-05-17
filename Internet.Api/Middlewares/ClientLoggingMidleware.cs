using Microsoft.AspNetCore.Diagnostics;

namespace Internet.API.Middlewares
{
    public class ClientLoggingMidleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public ClientLoggingMidleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
                string ip = context.Connection.RemoteIpAddress.MapToIPv4().ToString();
                string userName = context.User.Identity.Name;
                string time = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Europe/Minsk").ToLongTimeString();
                string request = context.Request.Method + context.Request.Path;
                _logger.LogInformation($"{time} Client ip: {ip}, username: {userName}, {request}");
            }
            catch
            {

            }
        }
    }
}
