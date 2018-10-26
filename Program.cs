using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3RestServiceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            RestServiceHandler handler = new RestServiceHandler();
            handler.PostCostumer(new Customer(4, "Test", "Testersen", 2017));

            Console.ReadKey();

            List<Customer> customerList = handler.GetCustomers();
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer);
            }

            handler.UpdateCostumer(4, new Customer(4, "Tester", "Testerer", 2018));
            Console.ReadKey();

            customerList = handler.GetCustomers();
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer);
            }

            Console.ReadKey();

            handler.DeleteCustomer(4);
            Console.ReadKey();

            customerList = handler.GetCustomers();
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer);
            }

            Console.ReadLine();
        }
    }
}
