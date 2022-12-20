using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

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
        /// <summary> API Request to get all Tasks </summary>
        /// <returns>All Tasks</returns>
        public List<Task> GetTasks()
        {
            try {
                var res = client.GetAsync("").Result;
                var tasks = res.Content.ReadFromJsonAsync<List<Task>>().Result;
                MessageBox.Show(res.StatusCode.ToString());
                return tasks;
            } 
            catch (Exception e){
                MessageBox.Show(e.Message);
                return new List<Task>();
            }
        }

        /// <summary> API Request to create a Task </summary>
        /// <param name="task"></param>
        public void Create(Task task)
        {
            var res = client.PostAsJsonAsync<Task>("", task).Result;
        }

        /// <summary> API Request to Update a Task </summary>
        /// <param name="task"></param>
        public void Update(Task task)
        {
            var res = client.PutAsJsonAsync<Task>("", task).Result;
        }

        /// <summary> API Request to delete a Task by ID </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var res = client.DeleteAsync("/" + id.ToString()).Result;
        }
    }
}
