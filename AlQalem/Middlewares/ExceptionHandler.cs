
using AlQalem.Exceptions;
using Newtonsoft.Json;

namespace AlQalem.Middlewares
{
    public class ExceptionHandler
    {
        private readonly RequestDelegate _next;

        public ExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var statusCode = StatusCodes.Status500InternalServerError;
            var message = "حدث خطأ غير متوقع.";

            
            if (exception is CustomException customException)
            {
                statusCode = StatusCodes.Status400BadRequest;
                message = customException.Message;
            }
            

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            var response = new
            {
                StatusCode = statusCode,
                Message = message
            };

            return context.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }
}
