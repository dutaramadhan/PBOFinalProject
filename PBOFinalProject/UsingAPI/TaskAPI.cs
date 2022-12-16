using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace PBOFinalProject.UsingAPI
{
    internal class TaskAPI
    {
        HttpClient client;
        public TaskAPI()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            client = new HttpClient(handler);
            client.BaseAddress = new Uri("https://localhost:7235/api/Task");
        }
        /// <summary>
        /// API Request to get all Tasks
        /// </summary>
        /// <returns>All Tasks</returns>
        public List<Task> GetTasks()
        {
            try {
                var res = client.GetAsync("").Result;
                var tasks = res.Content.ReadFromJsonAsync<List<Task>>().Result;
                return tasks;
            } 
            catch (Exception e){
                return new List<Task>();
            }
        }
        public void Create(Task task)
        {

        }
    }
}
