using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HtmlAgilityPack;
using System.IO;
using System.Web;
using System.Net.Http;


namespace TranslationService
{

    public class Service1 : IService1
    {
        public string translatedText(string sentText)
        {
            string returnedText = string.Empty;

            returnedText = TranslateText(sentText);
            
            return returnedText;
        }

        string TranslateText(string userText)
        {
            string host = "https://api.cognitive.microsofttranslator.com";
            string route = "/translate?api-version=3.0&to=es";
            string subscriptionKey = "805b661ae7074d69b5e0d4a78305dd4b";

            Object[] body = new Object[] { new { Text = userText } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(host + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

                var response = client.SendAsync(request).Result;
                var jsonResponse = response.Content.ReadAsStringAsync().Result;

                dynamic var1 = JsonConvert.DeserializeObject(jsonResponse);
                var text = var1[0].translations[0].ToString();

                var data = (JObject)JsonConvert.DeserializeObject(text);
                string translatedString = data["text"].Value<string>();

                return translatedString;
            }
        }
    }
}