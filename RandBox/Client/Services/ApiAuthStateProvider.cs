using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace RandBox.Client.Services
{
    public class ApiAuthStateProvider /*: AuthenticationStateProvider*/
    {
        /*private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _httpClient;

        public ApiAuthStateProvider(ILocalStorageService localStorage, IHttpClientFactory clientFactory)
        {
            _localStorage = localStorage;
            _httpClient = clientFactory.CreateClient("RandBox.ServerAPI.private");
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {

        }

        public static IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {

        }

        public static byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: 
                    base64 += "=="; 
                    break;
                case 3: 
                    base64 += "="; 
                    break;
            }
            return Convert.FromBase64String(base64);
        }*/
    }
}
