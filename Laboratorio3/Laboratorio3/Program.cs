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
            bool turnon = true;
            do
            {
                Console.WriteLine("¿Desea crear los elementos de forma aleatoria o manual?");
                Console.WriteLine("Opción 1: Forma manual ");
                Console.WriteLine("Opción 2: Forma aleatoria ");
                Console.WriteLine("Opción 3: Salir ");
                string election = Console.ReadLine();

                if (election == "1")
                {
                    bool turnon2 = true;
                    do
                    {
                        Console.WriteLine("¿Qué desea agregar?");
                        Console.WriteLine("Opción 1: Cliente ");
                        Console.WriteLine("Opción 2: Empleado ");
                        Console.WriteLine("Opción 3: Producto ");
                        Console.WriteLine("Opción 4: Salir ");
                        string election2 = Console.ReadLine();

                        if (election2 == "1")
                        {
                            Console.WriteLine("Ingrese nombre del cliente: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Ingrese apellido del cliente: ");
                            string surname = Console.ReadLine();
                            Console.WriteLine("Ingrese edad del cliente: ");
                            bool turnon3 = true;
                            string Age = "";
                            do
                            {
                                int counter = 0;
                                Age = Console.ReadLine();
                                for (int i = 0; i < Age.Length; i++)
                                {
                                    if (Age[i] >= 0 && Age[i] <= 9)
                                    {
                                        counter += 1;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (counter == Age.Length)
                                {
                                    turnon3 = false;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            while (turnon3 == true);
                            int age2 = Convert.ToInt32(Age);

                            Console.WriteLine("Ingrese el género del cliente (Femenino o Masculino: ");
                            string sex = Console.ReadLine();
                            Console.WriteLine("Ingrese el rut del cliente (sin guión y si termina con k, reemplazar por 0): ");
                            bool turnon4 = true;
                            string Rut = "";
                            do
                            {
                                int counter = 0;
                                Rut = Console.ReadLine();
                                for (int i = 0; i < Rut.Length; i++)
                                {
                                    if (Rut[i] >= 0 && Rut[i] <= 9)
                                    {
                                        counter += 1;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (counter == Rut.Length)
                                {
                                    turnon4 = false;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            while (turnon4 == true);
                            int rut2 = Convert.ToInt32(Rut);
                            Console.WriteLine("Ingrese la fecha de nacimiento del cliente (día/mes/año): ");
                            string birthdate = Console.ReadLine();
                            Console.WriteLine("Ingrese la nacionalidad del cliente: ");
                            string nationality = Console.ReadLine();

                            bool turnon5 = true;
                            Dictionary<string, int> clientwishes= new Dictionary<string, int>(); 
                            while (turnon5 == true)
                            {
                                Console.WriteLine("Ingrese el nombre de su producto: ");
                                string nameproduct=Console.ReadLine();
                                Console.WriteLine("Ingrese la marca de su producto: ");
                                string brandproduct = Console.ReadLine();
                                Console.WriteLine("Ingrese la cantidad: ");
                                string quantity = Console.ReadLine();
                                int quantityproduct = Convert.ToInt32(quantity);
                                clientwishes.Add(nameproduct,quantityproduct);
                                Console.WriteLine("¿Desea agregar algo más?");
                                Console.WriteLine("Opción 1: Sí");
                                Console.WriteLine("Opción 2: No");
                                string answer = Console.ReadLine();
                                if (answer == "1")
                                {
                                    continue;
                                }
                                else
                                {
                                    turnon5 = false;
                                }


                            }


                            Client newclient = new Client(name, surname, age2, sex, rut2, birthdate, nationality, clientwishes);
                            clients.Add(newclient);
                            Console.ReadKey();

                        }

                        else if (election2 == "2")
                        {
                            Console.WriteLine("Ingrese nombre del empleado: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Ingrese apellido del empleado: ");
                            string surname = Console.ReadLine();
                            Console.WriteLine("Ingrese edad del empleado: ");
                            bool turnon3 = true;
                            string Age = "";
                            do
                            {
                                int counter = 0;
                                Age = Console.ReadLine();
                                for (int i = 0; i < Age.Length; i++)
                                {
                                    if (Age[i] >= 0 && Age[i] <= 9)
                                    {
                                        counter += 1;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (counter == Age.Length)
                                {
                                    turnon3 = false;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            while (turnon3 == true);
                            int age2 = Convert.ToInt32(Age);

                            Console.WriteLine("Ingrese el género del empleado (Femenino o Masculino: ");
                            string sex = Console.ReadLine();
                            Console.WriteLine("Ingrese el rut del empleado (sin guión y si termina con k, reemplazar por 0): ");
                            bool turnon4 = true;
                            string Rut = "";
                            do
                            {
                                int counter = 0;
                                Rut = Console.ReadLine();
                                for (int i = 0; i < Rut.Length; i++)
                                {
                                    if (Rut[i] >= 0 && Rut[i] <= 9)
                                    {
                                        counter += 1;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (counter == Rut.Length)
                                {
                                    turnon4 = false;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            while (turnon4 == true);
                            int rut2 = Convert.ToInt32(Rut);
                            Console.WriteLine("Ingresela fecha de nacimiento del empleado (día/mes/año): ");
                            string birthdate = Console.ReadLine();
                            Console.WriteLine("Ingrese la nacionalidad del empleado: ");
                            string nationality = Console.ReadLine();
                            Console.WriteLine("Ingrese cargo del empleado: ");
                            string position = Console.ReadLine();
                            Console.WriteLine("Ingrese el sueldo del empleado: ");
                            bool turnon5 = true;
                            string Salary = "";
                            do
                            {
                                int counter = 0;
                                Salary = Console.ReadLine();
                                for (int i = 0; i < Salary.Length; i++)
                                {
                                    if (Salary[i] >= 0 && Salary[i] <= 9)
                                    {
                                        counter += 1;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (counter == Salary.Length)
                                {
                                    turnon5 = false;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            while (turnon5 == true);
                            int salary = Convert.ToInt32(Salary);
                            Console.WriteLine("Ingrese el horario del empleado (Hora inicio- hora término): ");
                            string workinghours = Console.ReadLine();
                            Employee newemployee = new Employee(name, surname, age2, sex, rut2, birthdate, nationality, position, salary, workinghours); //Hago el constructor de la canción
                            employees.Add(newemployee);
                            Console.ReadKey();


                        }
                        else if (election2 == "3")
                        {
                            Console.WriteLine("Ingrese nombre del producto: ");
                            string nameproduct = Console.ReadLine();
                            Console.WriteLine("Ingrese marca del product: ");
                            string brand = Console.ReadLine();
                            Console.WriteLine("Ingrese precio del producto: ");
                            bool turnon3 = true;
                            string Price = "";
                            do
                            {
                                int counter = 0;
                                Price = Console.ReadLine();
                                for (int i = 0; i < Price.Length; i++)
                                {
                                    if (Price[i] >= 0 && Price[i] <= 9)
                                    {
                                        counter += 1;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (counter == Price.Length)
                                {
                                    turnon3 = false;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            while (turnon3 == true);
                            int price = Convert.ToInt32(Price);

                            Console.WriteLine("Ingrese el stock en vitrina: ");
                            bool turnon4 = true;
                            string Stockinshowcase = "";
                            do
                            {
                                int counter = 0;
                                Stockinshowcase = Console.ReadLine();
                                for (int i = 0; i < Stockinshowcase.Length; i++)
                                {
                                    if (Stockinshowcase[i] >= 0 && Stockinshowcase[i] <= 9)
                                    {
                                        counter += 1;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (counter == Stockinshowcase.Length)
                                {
                                    turnon4 = false;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            while (turnon4 == true);
                            int stockinshowcase = Convert.ToInt32(Stockinshowcase);

                            Console.WriteLine("Ingrese el stock en bodega: ");
                            bool turnon5 = true;
                            string Stockincellar = "";
                            do
                            {
                                int counter = 0;
                                Stockincellar = Console.ReadLine();
                                for (int i = 0; i < Stockincellar.Length; i++)
                                {
                                    if (Stockincellar[i] >= 0 && Stockincellar[i] <= 9)
                                    {
                                        counter += 1;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (counter == Stockincellar.Length)
                                {
                                    turnon4 = false;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            while (turnon5 == true);
                            int stockincellar = Convert.ToInt32(Stockincellar);
                            Console.WriteLine("Ingrese el tipo de producto: ");
                            string type = Console.ReadLine();
                            Product newproduct = new Product(nameproduct, price,  brand,  stockinshowcase,  stockincellar,  type);
                            products.Add(newproduct);
                            Console.ReadKey();


                        }
                        else if (election2 == "4")
                        {
                            turnon2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Error. Esa opción no existe. Saliendo del programa.");
                            Console.ReadKey();
                            turnon2 = false;
                        }
                    }
                    while (turnon2 == true);
                }
               /* else if (election == "2")
                {
                    for (int i = 0; i <= 15; i++)
                    {
                        Client newclient = new Client();
                        clients.Add(newclient);
                    }
                    for (int i = 0; i <= 7; i++)
                    {
                        Employee newemployee = new Employee( name,  surname,  age,  sex,  rut,  birthdate,  nationality,  position,  salary,  workinghours);
                        employees.Add(newemployee);
                    }

                    for (int i = 0; i <= 30; i++)
                    {
                        string nameproduct=

                        Product newproduct = new Product( nameproduct,  price,  brand,  stockinshowcase,  stockincellar,  type);
                        products.Add(newproduct);
                    }
                    foreach (Product i in products)
                    {
                        Console.WriteLine(i.ProductInformation());
                    }
                    foreach (Client i in clients)
                    {
                        Console.WriteLine(i.ClientInformation());
                    }
                    foreach (Employee i in employees)
                    {
                        Console.WriteLine(i.EmployeeInformation());
                    }

                    Console.ReadKey();

                }*/
                else if (election == "3")
                {
                    turnon = false;
                }
                else
                {
                    Console.WriteLine("Error. Esa opción no existe. Saliendo del programa.");
                    Console.ReadKey();
                    turnon = false;
                }
            }
            while (turnon == true);
                 
        }
    }
}



