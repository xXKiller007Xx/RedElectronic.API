using Newtonsoft.Json;
using System.Text;

namespace RedElectronic.Util.Util
{
    /// <summary>
    /// Class for working with HttpClient, also parsing the response data
    /// </summary>
    public static class HttpClientHelper
    {
        /// <summary>
        /// Get Async
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="url">url</param>
        /// <param name="mediaType">mediaType</param>
        /// <param name="headers">Header</param>
        /// <returns></returns>
        public static async Task<T> GetAsync<T>(string url, Dictionary<string, string> headers = null)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {

                    if (headers != null)
                    {
                        foreach (var header in headers)
                        {
                            client.DefaultRequestHeaders.Add(header.Key, header.Value);
                        }
                    }

                    using (HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        T result = JsonConvert.DeserializeObject<T>(responseContent);
                        return result;
                    }
                }
                catch (HttpRequestException ex)
                {
                    return default;
                }
            }
        }
        /// <summary>
        /// Post Async
        /// </summary>
        /// <typeparam name="T">object</typeparam>
        /// <param name="url">url</param>
        /// <param name="requestBody">Request Body</param>
        /// <param name="headers">Headers</param>
        /// <returns>T</returns>
        public static async Task<T> PostAsync<T>(string url, string requestBody, string mediaType, Dictionary<string, string> headers = null)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    using (StringContent content = new StringContent(requestBody, Encoding.UTF8, mediaType))
                    {

                        if (headers != null)
                        {
                            foreach (var header in headers)
                            {
                                client.DefaultRequestHeaders.Add(header.Key, header.Value);
                            }
                        }

                        using (HttpResponseMessage response = await client.PostAsync(url, content))
                        {
                            response.EnsureSuccessStatusCode();
                            string responseContent = await response.Content.ReadAsStringAsync();
                            T result = JsonConvert.DeserializeObject<T>(responseContent);
                            return result;
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    return default;
                }
            }
        }
    }
}
