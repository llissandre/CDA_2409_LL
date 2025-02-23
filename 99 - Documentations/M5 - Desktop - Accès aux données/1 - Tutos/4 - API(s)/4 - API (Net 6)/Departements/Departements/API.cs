using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Departements
{
    internal class API
    {
        private readonly HttpClient _httpClient = new();

        public async Task<IEnumerable<Departement>> CallRESTAsync(string url)
        {
            var response = await CallHttpClient(url);

            if (response.IsSuccessStatusCode)
            {
                string jsonText = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<IEnumerable<Departement>>(jsonText);
            }
            else
                throw new HttpRequestException();
        }

        private async Task<HttpResponseMessage> CallHttpClient(string url)
        {
            HttpResponseMessage response;

            response = await _httpClient.GetAsync(url);

            return response;
        }
    }
}
