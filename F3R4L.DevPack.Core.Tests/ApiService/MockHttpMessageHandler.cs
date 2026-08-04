namespace F3R4L.DevPack.Api.Tests.ApiService
{
    public class MockHttpMessageHandler : HttpMessageHandler
    {
        private Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> _sendAsyncFunc;

        public Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> SendAsyncFunction
        {
            get
            {
                if (_sendAsyncFunc == null)
                {
                    throw new InvalidOperationException("SendAsyncFunction has not been set.");
                }
                return _sendAsyncFunc;
            }
            set
            {
                _sendAsyncFunc = value;
            }
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return await _sendAsyncFunc(request, cancellationToken);
        }
    }
}
