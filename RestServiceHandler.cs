using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace E3RestServiceConsumer
{
    public class RestServiceHandler
    {
        public List<Customer> GetCustomers()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = client.GetStringAsync("http://localhost:55210/api/Customers").Result;
                List<Customer> customerList = JsonConvert.DeserializeObject<List<Customer>>(content);
                return customerList;
            }
        }

        public void PostCostumer(Customer customer)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:55210/api/Customers", customer).Result;
            }
        }

        public void UpdateCostumer(int id, Customer customer)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.PutAsJsonAsync($"http://localhost:55210/api/Customers/{id}", customer).Result;
            }
        }

        public void DeleteCustomer(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.DeleteAsync($"http://localhost:55210/api/Customers/{id}").Result;
            }
        }
    }
}
