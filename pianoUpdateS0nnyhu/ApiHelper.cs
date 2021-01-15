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
        private HttpClient client;
        private String token;
        private const string URL = "https://api.github.com";

        private const string DATA = @"{""object"":[{""name"":""Name""}]}";

        public ApiHelper(String token)
        {
            client = new HttpClient();
            this.token = token;
        }

        public String getInfoRepository()
        {
            
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("AppName", "1.0"));
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", token);

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

        public List<Music> getFile()
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
    }
}
