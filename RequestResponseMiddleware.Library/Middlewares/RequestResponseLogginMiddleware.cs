
namespace RequestResponseMiddleware.Library.Middlewares
{
    public class RequestResponseLogginMiddleware
    {
        private readonly RequestDelegate next;

        public async Task Invoke(HttpContext context)
        {
            await next(context);
        }



    }
}
