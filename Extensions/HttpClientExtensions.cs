using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsForm.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<T> GetAsJsonAsync<T>(this HttpClient client,string url) where T:class,new()
        {
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<T>();
                }
                else
                {
                    return null;
                }
            }
        }

        public static async Task<T> PostAsJsonAsync<T>(this HttpClient client, string url, object entity) where T:class,new()
        {
            var stringEntity = JsonConvert.SerializeObject(entity);
            HttpContent content = new StringContent(stringEntity, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            else
            {
                return null;
            }
        }
        public static async Task<T> PutAsJsonAsync<T>(this HttpClient client, string url, object entity) where T : class, new()
        {
            var stringEntity = JsonConvert.SerializeObject(entity);
            HttpContent content = new StringContent(stringEntity, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            else
            {
                return null;
            }
        }
    }
}
