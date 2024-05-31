using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PostDataClass;
using FacebookIntegration; // Adicione esta linha

namespace FacebookIntegration
{
    public class FbIntegration : IFbIntegration
    {
        private readonly HttpClient _httpClient;
        private readonly AppConfig _appConfig;
        private readonly ModelLog _modelLog;

        public FbIntegration(AppConfig appConfig)
        {
            _httpClient = new HttpClient();
            _appConfig = appConfig;
            _modelLog = new ModelLog();
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
                    _modelLog?.ErrorLog($"Erro ao chamar o serviço: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                _modelLog?.ErrorLog($"Erro ao chamar o serviço: {ex.Message}");
            }

            return postDataList;
        }
    }
}
