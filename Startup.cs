using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseSpaMode();
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }

    public static class AppBuilderExtensions
    {
        public static IApplicationBuilder UseSpaMode(this IApplicationBuilder app, SpaMiddlewareOptions options = null)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));
            if (options == null)
                options = SpaMiddlewareOptions.Default;

            return app.Use(next => new SpaMiddleware(next, options).Invoke);
        }
    }
}
