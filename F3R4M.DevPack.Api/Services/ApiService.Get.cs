using F3R4M.DevPack.Api.Endpoints;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace F3R4M.DevPack.Api.Services
{
    public partial class ApiService
    {
        public async Task<T> GetAsync<T>(IApiEndpoint<T> apiEndpoint)
        {
            return new WebRequest
        }
    }
}
