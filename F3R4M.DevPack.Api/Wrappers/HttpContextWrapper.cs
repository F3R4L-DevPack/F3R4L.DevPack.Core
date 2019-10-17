using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4M.DevPack.Api.Wrappers
{
    internal class HttpContextWrapper : IHttpContext
    {
        private HttpContext _httpContext;
        private HttpRequestWrapper _requestWrapper;
        private HttpSessionStateWrapper _sessionWrapper;

        public HttpContextWrapper(HttpContext httpContext)
        {
            _httpContext = httpContext;
        }

        public IHttpRequest Request => _requestWrapper ?? (_requestWrapper = new HttpRequestWrapper(_httpContext.Request));
    }
}
