// lifted from https://github.com/beaupalmquist-hdqc/microservice-client-workshop-2016/tree/master/projects/Microservice.Clients/Spa.Middleware
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    public class SpaMiddlewareOptions
    {
        public PathString EntryPath { get; set; }

        public bool Html5Mode
        {
            get
            {
                return EntryPath.HasValue;
            }
        }

        public static SpaMiddlewareOptions Default
        {
            get
            {
                return defaults;
            }
        }

        private static SpaMiddlewareOptions defaults = new SpaMiddlewareOptions
        {
            EntryPath = new PathString("/index.html")
        };
    }
}
