using Microsoft.AspNetCore.Components;
using Toolbelt.Blazor;

namespace RandBox.Client.Services
{
    public class HttpInterceptorService
    {
        private readonly HttpClientInterceptor _interceptor;
        private readonly NavigationManager _navManager;

        public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navManager)
        {
            _interceptor = interceptor;
            _navManager = navManager;
        }

        public void RegisterEvent() => _interceptor.AfterSend += InterceptResponse;

        private void InterceptResponse(object? sender, HttpClientInterceptorEventArgs e)
        {
            if (!e.Response.IsSuccessStatusCode)
            {
                var responseCode = e.Response.StatusCode;
                switch(responseCode)
                {
                    case System.Net.HttpStatusCode.NotFound:
                        _navManager.NavigateTo("/404");
                        return;
                    case System.Net.HttpStatusCode.Unauthorized:
                    case System.Net.HttpStatusCode.Forbidden:
                        _navManager.NavigateTo("/unauthorized");
                        return;
                    default:
                        _navManager.NavigateTo("/500");
                        return;
                }
            }
        }

        public void DisposeEvent() => _interceptor.AfterSend -= InterceptResponse;
    }
}
