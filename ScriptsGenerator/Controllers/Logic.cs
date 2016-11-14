using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ScriptsGenerator.Models;

namespace ScriptsGenerator.Controllers
{
    public class Logic
    {
        private const string _getMarketingListId = "/api/crm/GetMarketingListId?marketingListName=";
        private const string _postTokenUrl = "/token";
        private Uri _apiBaseUri = null;
        private string _accessToken = string.Empty;
        private string _brandPatnerId;
        private HttpClient _httpClient;
        private string _crmApplicationId = string.Empty;
        private string _crmApplicationKey = string.Empty;
        private string _grantType = string.Empty;

        public Logic()
        {
            _crmApplicationId = System.Configuration.ConfigurationManager.AppSettings["crmApplicationId"].ToString();
            _crmApplicationKey = System.Configuration.ConfigurationManager.AppSettings["crmApplicationKey"].ToString();
            _grantType = System.Configuration.ConfigurationManager.AppSettings["grantType"].ToString();
            _apiBaseUri = new Uri(System.Configuration.ConfigurationManager.AppSettings["boxApiUrl"].ToString());
        }

        #region Tool to update MarketingListId against MarketingListName

        public bool CreateUpdateScriptMarketingListId(int brandPartnerId)
        {
            var dbContext = new NeriumReportingSandbox2Entities();
            StringBuilder script = new StringBuilder();
            dynamic marketingList = (from s in dbContext.CapturePageTagInfoes select new { s.MarketingListName }).Distinct();

            foreach (var item in marketingList)
            {
                string marketingListId = GetMarketingListId(item.MarketingListName, brandPartnerId);

                string query = string.Format("UPDATE NeriumUP.CapturePageTagInfo SET MarketingListId='{0}',ModifiedBy='US5708',ModifiedDate=Current_TimeStamp WHERE MarketingListName ='{1}' \n\n", marketingListId, item.MarketingListName);

                script.Append(query);
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\nkumar\Desktop\Nerium Docs\us5708\script_" + Guid.NewGuid() + ".sql"))
            {
                file.WriteLine(script);
                file.Flush();
            }

            return true;
        }

        public string GetMarketingListId(string marketingListName, int brandPartnerId = 10098)
        {
            string _status = "";
            string requestURL = string.Empty;
            string rawResponse = null;
            string requestParameters = string.Empty;

            SetAccessToken(brandPartnerId);
            try
            {
                using (_httpClient = new HttpClient())
                {
                    GetHttpClientSetup(_httpClient);
                    string url = string.Format("{0}{1}", _getMarketingListId, marketingListName);
                    requestURL = string.Format("{0}{1}", _httpClient.BaseAddress, url);

                    var result = _httpClient.GetAsync(url).Result;

                    if (result.IsSuccessStatusCode)
                    {
                        rawResponse = result.Content.ReadAsStringAsync().Result;
                        _status = result.Content.ReadAsAsync<string>().Result;
                    }

                }

            }
            catch (Exception ex)
            {
            }
            return _status;
        }
        #endregion

        private void GetHttpClientSetup(HttpClient httpClient)
        {
            httpClient.BaseAddress = _apiBaseUri;
            httpClient.DefaultRequestHeaders.Add("Authorization", _accessToken);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void SetAccessToken(int customerId)
        {
            if (customerId != 0)
            {
                _brandPatnerId = customerId.ToString();
                if (string.IsNullOrEmpty(_accessToken.Trim()))
                {
                    BoxApiAuthenticationDto _boxApiAuthenticationDto = GetAPIToken(_brandPatnerId);
                    _accessToken = string.Format("{0} {1}", _boxApiAuthenticationDto.token_type, _boxApiAuthenticationDto.access_token);
                }
            }
        }

        private BoxApiAuthenticationDto GetAPIToken(string brandPatnerId)
        {
            string requestURL = string.Empty;
            string rawResponse = null;
            BoxApiAuthenticationDto _boxApiAuthenticationDto = new BoxApiAuthenticationDto();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using (_httpClient = new HttpClient(handler))
                {
                    _httpClient.BaseAddress = _apiBaseUri;
                    _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

                    _httpClient.DefaultRequestHeaders.Add("Application-ID", _crmApplicationId);
                    _httpClient.DefaultRequestHeaders.Add("Application-Key", _crmApplicationKey);
                    _httpClient.DefaultRequestHeaders.Add("ExigoBrandPartnerId", _brandPatnerId);

                    var content = new FormUrlEncodedContent(new[]
                                 {
                                  new KeyValuePair<string, string>("grant_type", _grantType)
                                 });

                    Dictionary<string, string> queryParameterBuilder = new Dictionary<string, string>();
                    queryParameterBuilder.Add("grant_type", _grantType);
                    var result = _httpClient.PostAsync(_postTokenUrl, content).Result;

                    if (result.IsSuccessStatusCode)
                    {
                        rawResponse = result.Content.ReadAsStringAsync().Result;
                        _boxApiAuthenticationDto = result.Content.ReadAsAsync<BoxApiAuthenticationDto>().Result;
                    }
                }
            }
            catch (Exception ex) { }
            return _boxApiAuthenticationDto;
        }
    }
}