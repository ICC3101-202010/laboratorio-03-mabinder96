using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Supermaket first = new Supermaket();
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
                        Console.WriteLine("Opción 4: Quiero comprar");
                        Console.WriteLine("Opción 5: Quiero modificar un empleado");
                        Console.WriteLine("Opción 6: Salir ");
                        string election2 = Console.ReadLine();

                        if (election2 == "1")
                        {
                            Console.WriteLine("Ingrese nombre del cliente: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Ingrese apellido del cliente: ");
                            string surname = Console.ReadLine();
                            bool turnon3;
                            string Age;
                            int age2;
                            do
                            {
                                Console.WriteLine("Ingrese edad del cliente: ");
                                Age = Console.ReadLine();
                                turnon3 = int.TryParse(Age, out age2);
                            }
                            while (!turnon3);
                            age2 = Convert.ToInt32(Age);

                            Console.WriteLine("Ingrese el género del cliente (Femenino o Masculino): ");
                            string sex = Console.ReadLine();
                            bool turnon4;
                            string Rut;
                            int rut2;
                            do
                            {
                                Console.WriteLine("Ingrese el rut del cliente (sin guión y si termina con k, reemplazar por 0): ");
                                Rut = Console.ReadLine();
                                turnon4 = int.TryParse(Rut, out rut2);
                            }
                            while (!turnon4);
                            rut2 = Convert.ToInt32(Rut);
                            Console.WriteLine("Ingrese la fecha de nacimiento del cliente (día/mes/año): ");
                            string birthdate = Console.ReadLine();
                            Console.WriteLine("Ingrese la nacionalidad del cliente: ");
                            string nationality = Console.ReadLine();

                            bool turnon5 = true;
                            Dictionary<string, int> clientwishes = new Dictionary<string, int>();
                            while (turnon5 == true)
                            {
                                Console.WriteLine("Ingrese el nombre del producto que desea comprar: ");
                                string nameproduct = Console.ReadLine();
                                bool turnon6;
                                string quantity;
                                int quantityproduct;
                                do
                                {
                                    Console.WriteLine("Ingrese la cantidad: ");
                                    quantity = Console.ReadLine();
                                    turnon6 = int.TryParse(quantity, out quantityproduct);
                                }
                                while (!turnon6);
                                quantityproduct = Convert.ToInt32(quantity);
                                clientwishes.Add(nameproduct, quantityproduct);
                                Console.WriteLine("¿Desea comprar algo más?");
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
                            first.AddClient(newclient);
                        }

                        else if (election2 == "2")
                        {
                            Console.WriteLine("Ingrese nombre del empleado: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Ingrese apellido del empleado: ");
                            string surname = Console.ReadLine();
                            bool turnon3;
                            string Age;
                            int age2;
                            do
                            {
                                Console.WriteLine("Ingrese edad del empleado: ");
                                Age = Console.ReadLine();
                                turnon3 = int.TryParse(Age, out age2);
                            }
                            while (!turnon3);
                            age2 = Convert.ToInt32(Age);

                            Console.WriteLine("Ingrese el género del empleado (Femenino o Masculino): ");
                            string sex = Console.ReadLine();
                            bool turnon4;
                            string Rut;
                            int rut2;
                            do
                            {
                                Console.WriteLine("Ingrese el rut del empleado (sin guión y si termina con k, reemplazar por 0): ");
                                Rut = Console.ReadLine();
                                turnon4 = int.TryParse(Rut, out rut2);
                            }
                            while (!turnon4);
                            rut2 = Convert.ToInt32(Rut);
                            Console.WriteLine("Ingresela fecha de nacimiento del empleado (día/mes/año): ");
                            string birthdate = Console.ReadLine();
                            Console.WriteLine("Ingrese la nacionalidad del empleado: ");
                            string nationality = Console.ReadLine();
                            Console.WriteLine("Ingrese cargo del empleado: ");
                            string position = Console.ReadLine();
                            bool turnon5;
                            string Salary;
                            int salary;
                            do
                            {
                                Console.WriteLine("Ingrese el sueldo del empleado: ");
                                Salary = Console.ReadLine();
                                turnon5 = int.TryParse(Salary, out salary);
                            }
                            while (!turnon5);
                            salary = Convert.ToInt32(Salary);

                            bool turnon9;
                            string Entry;
                            int entry;
                            do
                            {
                                Console.WriteLine("Ingrese horario de entrada: ");
                                Entry = Console.ReadLine();
                                turnon9 = int.TryParse(Entry, out entry);
                            }
                            while (!turnon9);
                            entry = Convert.ToInt32(Entry);

                            bool turnon10;
                            string Exit;
                            int exit;
                            do
                            {
                                Console.WriteLine("Ingrese horario de salida: ");
                                Exit = Console.ReadLine();
                                turnon10 = int.TryParse(Exit, out exit);
                            }
                            while (!turnon10);
                            exit = Convert.ToInt32(Exit);

                            Employee newemployee = new Employee(name, surname, age2, sex, rut2, birthdate, nationality, position, salary, entry, exit);
                            first.AddEmployee(newemployee);

                        }
                        else if (election2 == "3")
                        {
                            Console.WriteLine("Ingrese nombre del producto: ");
                            string nameproduct = Console.ReadLine();
                            Console.WriteLine("Ingrese marca del producto: ");
                            string brand = Console.ReadLine();
                            bool turnon3;
                            string Price;
                            int price;
                            do
                            {
                                Console.WriteLine("Ingrese precio del producto: ");
                                Price = Console.ReadLine();
                                turnon3 = int.TryParse(Price, out price);
                            }
                            while (!turnon3);
                            price = Convert.ToInt32(Price);

                            bool turnon4;
                            string Stock;
                            int stock;
                            do
                            {
                                Console.WriteLine("Ingrese el stock: ");
                                Stock = Console.ReadLine();
                                turnon4 = int.TryParse(Stock, out stock);
                            }
                            while (!turnon4);
                            stock = Convert.ToInt32(Stock);

                            Console.WriteLine("Ingrese el tipo de producto: ");
                            string type = Console.ReadLine();
                            Product newproduct = new Product(nameproduct, price, brand, stock, type);
                            first.AddProduct(newproduct);

                        }
                        else if (election2 == "4")
                        {
                            string ticket = first.Buy();
                            if (ticket.Count() == 0)
                            {
                                Console.WriteLine("No se tienen ventas");
                            }
                            else
                            {
                                Console.WriteLine(ticket);
                            }
                        }
                        else if (election2 == "5")
                        {
                            bool turnon8 = true;
                            do
                            {
                                bool turnon7;
                                string Rut;
                                int rut;
                                do
                                {
                                    Console.WriteLine("Ingrese el rut del empleado a modificar: ");
                                    Rut = Console.ReadLine();
                                    turnon7 = int.TryParse(Rut, out rut);
                                }
                                while (!turnon7);
                                rut = Convert.ToInt32(Rut);
                                Console.WriteLine("¿Qué desea modificar?");
                                Console.WriteLine("Opción 1: Cargo");
                                Console.WriteLine("Opción 2: Sueldo");
                                Console.WriteLine("Opción 3: Horas de trabajo");
                                string answer = Console.ReadLine();
                                first.ChangeEmployee(rut, answer);
                                Console.WriteLine("¿Desea modificar algo más?");
                                Console.WriteLine("Opción 1: Sí");
                                Console.WriteLine("Opción 2: No");
                                string option = Console.ReadLine();
                                if (option == "1")
                                {
                                    continue;
                                }
                                else
                                {
                                    turnon8 = false;
                                }
                            }
                            while (turnon8 == true);


                        }
                        else if (election2 == "6")
                        {
                            turnon2 = false;
                            turnon = false;
                        }
                        else
                        {
                            Console.WriteLine("Error. Esa opción no existe. Saliendo.");
                            Console.ReadKey();
                            turnon2 = false;
                            turnon = false;
                        }
                    }
                    while (turnon2 == true);
                }
                else if (election == "2")
                {
                    for (int i = 0; i <= 15; i++)
                    {
                        Client newclient = first.AddRandomClient();
                        first.AddClient(newclient);
                    }
                    for (int i = 0; i <= 7; i++)
                    {
                        Employee newemployee = first.AddRandomEmployee();
                        first.AddEmployee(newemployee);
                    }
                    for (int i = 0; i <= 30; i++)
                    {
                        Product newproduct = first.AddRandomProduct();
                        first.AddProduct(newproduct);
                    }
                    Console.WriteLine("INFORMACIÓN CLIENTES\n");
                    first.ClientsInformation();
                    Console.WriteLine(" \n");
                    Console.WriteLine("INFORMACIÓN EMPLEADOS\n");
                    first.EmployeesInformation();
                    Console.WriteLine(" \n");
                    Console.WriteLine("INFORMACIÓN PRODUCTOS\n");
                    first.ProductsInformation();
                    Console.WriteLine(" \n");
                    Console.WriteLine("¡A COMPRAR!");
                    string ticket = first.Buy();
                    if (ticket.Count() == 0)
                    {
                        Console.WriteLine("No se tienen ventas");
                    }
                    else
                    {
                        Console.WriteLine(ticket);
                    }
                }
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
