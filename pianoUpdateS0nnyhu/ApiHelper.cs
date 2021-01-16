using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pianoUpdateS0nnyhu
{


    class ApiHelper
    {
        static HttpClient client;
        static String token;
        private const string URL = "https://api.github.com";


        public static void initApiHelper(String token)
        {
            ApiHelper.token = token;
            client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("AppName", "1.0"));
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", token);
        }

        public static String getInfoRepository()
        {
            // List data response.
            HttpResponseMessage response = client.GetAsync("/repos/s0nnyhu/piano").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var data = response.Content.ReadAsStringAsync().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                dynamic dataObject = JObject.Parse(data);
                return "You are connected! " + " Welcome  " + dataObject.name; ;
            }
            else
            {
                return (int)response.StatusCode + " - " + response.ReasonPhrase;
            }
        }

        public static List<Music> getFile()
        {
            HttpClient dlClient = new HttpClient();

            dlClient.BaseAddress = new Uri("https://raw.githubusercontent.com");

            // Add an Accept header for JSON format.
            dlClient.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("AppName", "1.0"));
            dlClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            dlClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", token);

            // List data response.
            HttpResponseMessage response = dlClient.GetAsync("/s0nnyhu/piano/develop/data.json").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var data = response.Content.ReadAsStringAsync().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll

                /**
                dynamic dynJson = JsonConvert.DeserializeObject(data);
                foreach (var item in dynJson)
                {
                    Console.WriteLine("{0} {1} {2} {3}\n", item.title, item.origin,
                        item.link, item.credit);
                }
                **/

                var list = JsonConvert.DeserializeObject<List<Music>>(data);

                return list;
            }
            else
            {
                return null;
            }
        }

        public static String getSha()
        {
            // List data response.
            HttpResponseMessage response = client.GetAsync("/repos/s0nnyhu/piano/contents/data.json?ref=develop").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var data = response.Content.ReadAsStringAsync().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                dynamic dataObject = JObject.Parse(data);
                return dataObject.sha;
            }
            else
            {
                return null;
            }
        }

        public static String commit(String commitMessage, String content, String branch, String sha)
        {
            var values = new Dictionary<object, object>
            {
                { "message", commitMessage }, { "content", content },
                { "branch", branch }, { "sha", sha }
            };

            var formContent = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");

            var response = client.PutAsync("/repos/s0nnyhu/piano/contents/data.json", formContent).Result;

            var res = response.Content.ReadAsStringAsync().Result;
            dynamic dataObject = JObject.Parse(res);

            return dataObject.sha;
        }
    }
}
