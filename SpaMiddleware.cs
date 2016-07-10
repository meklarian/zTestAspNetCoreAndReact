// lifted from https://github.com/beaupalmquist-hdqc/microservice-client-workshop-2016/tree/master/projects/Microservice.Clients/Spa.Middleware
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication {
    public class SpaMiddleware {
        private readonly RequestDelegate _next;
        private readonly SpaMiddlewareOptions _options;

        public SpaMiddleware(RequestDelegate next, SpaMiddlewareOptions options)
        {
            _next = next;
            _options = options;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await _next.Invoke(httpContext);

            var requestSegments =
                httpContext.Request.Path.Value.ToLower()
                    .Split(new string[] {"/"}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            while (httpContext.Response.StatusCode == 404 && _options.Html5Mode && requestSegments.Count > 0)
            {
                requestSegments.RemoveAt(0);

                var combinedPath = Path.Combine(requestSegments.ToArray()).Replace("\\", "/");
                httpContext.Request.Path = "/" + combinedPath;
                await _next.Invoke(httpContext);
            }

            if (httpContext.Response.StatusCode == 404 && requestSegments.Count == 0)
            {
                httpContext.Request.Path = _options.EntryPath;
                await _next.Invoke(httpContext);
            }
        }
    }
    }