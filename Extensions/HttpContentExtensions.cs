using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsForm.Extensions
{
    public static class HttpContentExtensions
    {
        public static async Task<T> ReadAsAsync<T>(this HttpContent content) where T:class,new()
        {
            var stringEntity =await content.ReadAsStringAsync();
            if (String.IsNullOrEmpty(stringEntity))
            {
                return null;
            }
            return JsonConvert.DeserializeObject<T>(stringEntity);
        }
    }
}
