using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Project3_FinalExam.Services
{
    public class GetIndex
    {
        public async Task<IndexAbout> GetAbout()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/about", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(data);
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    var rtnResults = JsonConvert.DeserializeObject<IndexAbout>(data);
                    Debug.WriteLine(rtnResults.description);
                    Console.WriteLine(rtnResults);
                    //List<IndexAbout> GradList = new List<IndexAbout>();
                    IndexAbout indexAbout = new IndexAbout();

                    return rtnResults;



                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    IndexAbout iList = new IndexAbout();
                    return iList;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    IndexAbout iList = new IndexAbout();
                    return iList;
                }
            }
        }
    }
}
