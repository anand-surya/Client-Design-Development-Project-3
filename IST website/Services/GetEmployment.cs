using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Project3_FinalExam.Services
{
    public class GetEmployment
    {
        public async Task<List<Employment>> GetEmpTable()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/employment/employmentTable/professionalEmploymentInformation", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Employment>>>(data);
                    List<Employment> EmpList = new List<Employment>();
                    Employment employment = new Employment();

                    foreach (KeyValuePair<string, List<Employment>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            EmpList.Add(item);
                        }
                    }
     
                    return EmpList;



                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Employment> eList = new List<Employment>();
                    return eList;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<Employment> eList = new List<Employment>();
                    return eList;
                }
            }
        }
    }
}
