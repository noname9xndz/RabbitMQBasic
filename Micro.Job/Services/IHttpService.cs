using Micro.Common;
using System.Net.Http;
using System.Threading.Tasks;

namespace Micro.Job.Services
{
    public interface IHttpService
    {
        //        Task<T> SendAsync<T>(string url, HttpMethod method, HttpContent content);
        //
        //        Task<T> PostAsync<T>(string url, object body);
        //
        //        Task<T> PutAsync<T>(string url, object body);
        //
        //        Task<T> DeleteAsync<T>(string url, object body);

        Task<ApiResponse<T>> SendAsync<T>(string url, HttpMethod method, HttpContent content);

        Task<ApiResponse<T>> PostAsync<T>(string url, object body);

        Task<ApiResponse<T>> PutAsync<T>(string url, object body);

        Task<ApiResponse<T>> DeleteAsync<T>(string url, object body);
    }
}