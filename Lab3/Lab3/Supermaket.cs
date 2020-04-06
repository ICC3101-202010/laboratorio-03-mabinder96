using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Supermaket
    {
        public Supermaket()
        {

        }
        List<Product> products = new List<Product>();
        List<Client> clients = new List<Client>();
        List<Employee> employees = new List<Employee>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        static Random rnd = new Random();
        public string RandomSeller()
        {

            List<string> possibleSeller = new List<string>();
            foreach (Employee e in employees)
            {
                if (e.Position=="vendedor" || e.Position == "Vendedor")
                {
                    possibleSeller.Add(e.EmployeeInformation());
                }
                else
                {
                    continue;
                }
            }
            int index = rnd.Next(possibleSeller.Count);
            return possibleSeller[index];

        }


public string Buy()
        {
            string ticket = "";
            string shoppingcart="";
            string seller="";
            foreach (Client a in clients)
            {
                int totalprice = 0;
                foreach (KeyValuePair<string, int> i in a.Clientwishes)
                {
                    int price;
                    foreach (Product p in products)
                    {
                        string nameproduct = i.Key.ToLower();
                        if (p.Nameproduct == nameproduct && p.Stock >= i.Value)
                        {
                            price = i.Value * p.Price;
                            totalprice += price;
                            shoppingcart += "producto: " + i.Key + " cantidad: " + i.Value + " precio: " + price +"\n";
                            p.Stock -= i.Value;
                        }
                        else if (p.Nameproduct == nameproduct && p.Stock < i.Value && p.Stock>0)
                        {
                            price = p.Stock * p.Price;
                            totalprice += price;
                            shoppingcart += "producto: "+ i.Key + " cantidad: "+ p.Stock + " precio: "+ price;
                            p.Stock-=p.Stock;
                        }
                        else if (p.Nameproduct == nameproduct &&  p.Stock == 0)
                        {
                            shoppingcart += "producto: " + i.Key + " ,agotado";
                        }
                        else 
                        {
                            shoppingcart += "producto: " + i.Key + " ,no existe en la tienda";
                        }

                    }
                }
                seller = RandomSeller();
                DateTime now = DateTime.Now;
                ticket += "INFORMACIÓN CLIENTE: "+ a.ClientInformation()  +"\nCOMPRAS: " + shoppingcart + "\nVENDEDOR: "+  seller+  "\nPRECIO TOTAL: "+totalprice+ "\nFECHA Y HORA: "+ now + "\n";

            }
            return ticket; 
        }
    }
}
