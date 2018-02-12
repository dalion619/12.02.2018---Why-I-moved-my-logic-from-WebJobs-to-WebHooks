using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebJobExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CallWebHook().Wait();
            Console.ReadLine();
        }
        static async Task CallWebHook()
        {
            using (var httpClient = new HttpClient())
            {
                var url = "http://localhost:8629/";
                var taskname = await httpClient.PostAsync($"{url}api/webhooks/incoming/genericjson/taskname?code=forwebhookmysupersecrettousefor1", new StringContent(JsonConvert.SerializeObject(new { Payload = "Anything" }), Encoding.UTF8, "application/json"));
               
                Console.WriteLine($"taskname {taskname.StatusCode}");
            }
        }
          
    }
}
