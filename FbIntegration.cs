using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PostDataClass;

namespace FacebookIntegration
{
    public class FbIntegration : IFbIntegration
    {
        private readonly HttpClient _httpClient;
        private readonly AppConfig _appConfig;

        public FbIntegration(AppConfig appConfig)
        {
            _httpClient = new HttpClient();
            _appConfig = appConfig;
        }

        public async Task<List<PostData>> GetPostsAsync()
        {
            List<PostData> postDataList = new List<PostData>();

            try
            {
                string url = _appConfig.GetServiceUrlWithId();
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    postDataList = JsonConvert.DeserializeObject<List<PostData>>(jsonResponse);
                }
                else
                {
                    Console.WriteLine($"Erro ao chamar o servi�o: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao chamar o servi�o: {ex.Message}");
            }

            return postDataList;
        }
    }
}