using Micro.Common;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Micro.Job.Services
{
    public class HttpService : IHttpService
    {
        private HttpClient DefaultHttpClient()
        {
            return new HttpClient(new HttpClientHandler()); //
        }

        //public async Task<T> PostAsync<T>(string url, object body)
        //{
        //    var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

        //    return await SendAsync<T>(url, HttpMethod.Post, content);
        //}

        //public async Task<T> PutAsync<T>(string url, object body)
        //{
        //    var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

        //    return await SendAsync<T>(url, HttpMethod.Put, content);
        //}

        //public async Task<T> DeleteAsync<T>(string url, object body)
        //{
        //    var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

        //    return await SendAsync<T>(url, HttpMethod.Delete, content);
        //}

        //public async Task<T> SendAsync<T>(string url, HttpMethod method, HttpContent content = null)
        //{
        //    var request = new HttpRequestMessage(method, url);

        //    if (content != null)
        //        request.Content = content;

        //    using (var client = DefaultHttpClient())
        //    {
        //        var response = await client.SendAsync(request);
        //        var body = await response.Content.ReadAsStringAsync();

        //        return JsonConvert.DeserializeObject<T>(body);
        //    }
        //}

        //public async Task SendAsyncTest(string url, HttpMethod method, HttpContent content = null)
        //{
        //    var request = new HttpRequestMessage(method, url);

        //    if (content != null)
        //        request.Content = content;

        //    using (var client = DefaultHttpClient())
        //    {
        //        var response = await client.SendAsync(request);

        //        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        //        {
        //            var body = await response.Content.ReadAsStringAsync();
        //        }

        //    }
        //}

        public Task<ApiResponse<T>> PostAsync<T>(string url, object body)
        {
            var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

            return SendAsync<T>(url, HttpMethod.Post, content);
        }

        public Task<ApiResponse<T>> PutAsync<T>(string url, object body)
        {
            var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

            return SendAsync<T>(url, HttpMethod.Put, content);
        }

        public Task<ApiResponse<T>> DeleteAsync<T>(string url, object body)
        {
            var content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

            return SendAsync<T>(url, HttpMethod.Delete, content);
        }

        public async Task<ApiResponse<T>> SendAsync<T>(string url, HttpMethod method, HttpContent content = null)
        {
            var request = new HttpRequestMessage(method, url);

            if (content != null)
                request.Content = content;

            using (var client = DefaultHttpClient())
            {
                var response = await client.SendAsync(request);
                var body = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ApiResponse<T>>(body);
            }
        }

        public async Task SendAsyncTest(string url, HttpMethod method, HttpContent content = null)
        {
            var request = new HttpRequestMessage(method, url);

            if (content != null)
                request.Content = content;

            using (var client = DefaultHttpClient())
            {
                var response = await client.SendAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var body = await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}