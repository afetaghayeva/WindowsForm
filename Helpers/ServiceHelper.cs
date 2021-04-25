using System.Net.Http;
using System.Threading.Tasks;
using WindowsForm.Entities.Concrete;
using WindowsForm.Extensions;

namespace WindowsForm.Helpers
{
    public static class ServiceHelper
    {
        public  static async Task<T> GetDataAsync<T>(string url) where T : class, new()
        {
            using (HttpClient client = new HttpClient())
            {
               return await client.GetAsJsonAsync<T>(url);
            }
        }

        public static async Task<T> PostDataAsync<T>(string url, object entity) where T:class,new()
        {
            using (HttpClient client=new HttpClient())
            {
                return await client.PostAsJsonAsync<T>(url, entity);
            }
        }

        public static async Task<T> UpdateDataAsync<T>(string url,object entity) where T : class, new()
        {
            using (HttpClient client=new HttpClient())
            {
                return await client.PutAsJsonAsync<T>(url, entity);
            }
        }
    }
}
