using CerezlikWeb.App.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CerezlikWeb.App.API
{
    public class APIService
    {
        static string serviceUrl = "";
        static HttpClient client = new HttpClient();
        static string url = Startup.StaticConfig["Root:ApiUrl"];

        public static async Task<List<Article>> GetAllArticle()
        {
            var httpResponse = await Get("Data/GetAllArticle");
            var l = JsonConvert.DeserializeObject<List<Article>>(httpResponse);
            return l.ToList();
        }

        public static async Task<Article> GetArticleById(Guid Id)
        {
            var httpResponse = await Get("Data/GetArticleById?Id=" + Id);
            var l = JsonConvert.DeserializeObject<Article>(httpResponse);
            return l;
        }

        public static async Task<List<Article>> GetArticleListByCategory(CategoryEnums e)
        {
            var httpResponse = await Get("Data/GetArticleListByCategory?category=" + e);
            var l = JsonConvert.DeserializeObject<List<Article>>(httpResponse);
            return l.ToList();
        }

        public async static Task<string> Post<T>(string method, T instance) where T : class, new()
        {
            if (string.IsNullOrEmpty(url))
                throw new Exception("api url not defined");
            serviceUrl = $"{url}{method}";

            StringContent httpContent = new StringContent(JsonConvert.SerializeObject(instance), Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await client.PostAsync(serviceUrl, httpContent).ConfigureAwait(false))
            {
                string res = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK && response.StatusCode != System.Net.HttpStatusCode.NoContent)
                {

                }
                return res;
            }
        }

        public static async Task<string> Get(string method)
        {
            if (string.IsNullOrEmpty(url))
            {
                var error = "api url not defined";
                throw new Exception(error);
            }
            serviceUrl = $"{url}{method}";
            using (HttpResponseMessage response = await client.GetAsync(serviceUrl).ConfigureAwait(false))
            {
                string res = await response.Content.ReadAsStringAsync();

                if (response.StatusCode != System.Net.HttpStatusCode.OK && response.StatusCode != System.Net.HttpStatusCode.NoContent)
                {
                    //var error = new ErrorApiModel() { Message = res, StatusCode = response.StatusCode.ToString() };
                    //logger.LogError(res);
                    return string.Empty;
                }
                //else if (response.StatusCode == System.Net.HttpStatusCode.NoContent && string.IsNullOrEmpty(res))
                //{
                //    //return error.Message;
                //}

                return res;
            }
        }
    }
}
