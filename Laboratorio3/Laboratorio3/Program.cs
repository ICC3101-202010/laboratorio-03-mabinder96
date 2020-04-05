using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            List<Client> clients = new List<Client>();
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i <= 15; i++)
            {
                Client newclient = new Client();
                clients.Add(newclient);
            }
            for (int i = 0; i <= 7; i++)
            {
                Employee newemployee = new Employee();
                employees.Add(newemployee);
            }

            for (int i = 0; i <= 7; i++)
            {
                Product newproduct = new Product();
                products.Add(newproduct);
            }
        }
    }
}


