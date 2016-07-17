using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Doctors.Network
{
    class ServiceHttpClient
    {
        private static ServiceHttpClient _instance;

        public static ServiceHttpClient GetInstance()
        {
            return _instance ?? (_instance = new ServiceHttpClient());
        }

        internal async Task<string> DownloadContents(string url)
        {
            string contents;
            using (var httpClient = new HttpClient())
            {
                contents = await httpClient.GetStringAsync(new Uri(url));
            }
            return contents;
        }


        internal async Task<string> PostContents(string url, string json)
        {
            string serverResponse;
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync(url, new StringContent(json, Encoding.UTF8, "Application/json"))
                    .ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());
                serverResponse = await response.Content.ReadAsStringAsync();
            }
            return serverResponse;
        }

    }
}
