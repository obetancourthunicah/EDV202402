using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicasMedicasDao.Web
{
    public class WebContext
    {
        static HttpClient httpClient = new HttpClient();

        public static async Task<string> get(string url) {
            try
            {
                using HttpResponseMessage result = await httpClient.GetAsync(url);
                result.EnsureSuccessStatusCode();
                if (result.IsSuccessStatusCode)
                {
                    return await result.Content.ReadAsStringAsync();
                }
                return "error";
            }
            catch (Exception ex)
            {
                return "error";
            }
        }

        public static async Task<string> getWithQueryParams(string url, Dictionary<string, string> queryParams) {
            try
            {
                string urlWithParams = url + "?";
                foreach (var item in queryParams)
                {
                    urlWithParams += item.Key + "=" + item.Value + "&";
                }
                HttpResponseMessage result = await httpClient.GetAsync(new Uri(urlWithParams));
                if (result.IsSuccessStatusCode)
                {
                    return await result.Content.ReadAsStringAsync();
                }
                return "error";
            }
            catch (Exception ex)
            {
                return "error";
            }
        }

        public static async Task<string> post(string url, string json) {
            try
            {
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage result = await httpClient.PostAsync(new Uri(url), content);
                if (result.IsSuccessStatusCode)
                {
                    return await result.Content.ReadAsStringAsync();
                }
                return "error";
            }
            catch (Exception ex)
            {
                return "error";
            }
        }
    }
}
