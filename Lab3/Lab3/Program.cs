using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo el supermercado
            Supermaket first = new Supermaket();

            //Hago un ciclo para cuando el usuario desee salir, salga
            bool turnon = true;
            do
            {
                Console.WriteLine("¿Desea crear los elementos de forma aleatoria o manual?");
                Console.WriteLine("Opción 1: Forma manual ");
                Console.WriteLine("Opción 2: Forma aleatoria ");
                Console.WriteLine("Opción 3: Salir ");
                string election = Console.ReadLine();

                //Si elige la opción 1, creo las cosas de forma manual
                if (election == "1")
                {
                    //Hago otro ciclo para cuando la persona desee salir vuelva al menú principal
                    bool turnon2 = true;
                    do
                    {
                        Console.WriteLine("¿Qué desea agregar?");
                        Console.WriteLine("Opción 1: Cliente ");
                        Console.WriteLine("Opción 2: Empleado ");
                        Console.WriteLine("Opción 3: Producto ");
                        Console.WriteLine("Opción 4: Comprar por rut"); //Selecciono el cliente que quiero que compre según su rut
                        Console.WriteLine("Opción 5: Quiero comprar todo de una"); //Compro todos los productos disponibles que tengan los clientes en sus listas de deseos
                        Console.WriteLine("Opción 6: Quiero modificar un empleado");
                        Console.WriteLine("Opción 7: Salir al menú principal ");
                        string election2 = Console.ReadLine();

                        //Si elige la opción 1, creo al cliente
                        if (election2 == "1")
                        {
                            Console.WriteLine("Ingrese nombre del cliente: ");
                            string name = Console.ReadLine(); //Establezco el nombre del cliente
                            Console.WriteLine("Ingrese apellido del cliente: ");
                            string surname = Console.ReadLine(); //Establezco el apellido del cliente
                            //Creo un ciclo para comprobar que la edad sea un número
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
                            age2 = Convert.ToInt32(Age); //Establezco la edad del cliente
                            Console.WriteLine("Ingrese el género del cliente (Femenino o Masculino): ");
                            string sex = Console.ReadLine(); //Establezco el sexo del cliente
                            //Creo un ciclo para comprobar que el rut sea un número
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
                            rut2 = Convert.ToInt32(Rut); //Establezco el rut del cliente
                            Console.WriteLine("Ingrese la fecha de nacimiento del cliente (día/mes/año): ");
                            string birthdate = Console.ReadLine(); //Establezo la fecha de nacimiento del cliente
                            Console.WriteLine("Ingrese la nacionalidad del cliente: ");
                            string nationality = Console.ReadLine(); //Establezco la nacionalidad del cliente
                            Dictionary<string, int> clientwishes = new Dictionary<string, int>();
                            bool turnon7 = true;
                            do
                            {
                                Console.WriteLine("¿Desea comprar?");
                                Console.WriteLine("Opción 1: Sí");
                                Console.WriteLine("Opción 2: No");
                                string answ = Console.ReadLine();
                                if (answ == "1")
                                {
                                    //Creo un ciclo para crear la lista de deseos del cliente y el usuario decida cuando dejar de agregar productos
                                    bool turnon5 = true;
                                    while (turnon5 == true)
                                    {
                                        Console.WriteLine("Ingrese el nombre del producto que desea comprar: ");
                                        string nameproduct = Console.ReadLine(); //Establezco el nombre del producto
                                        //Creo un ciclo para comprobar que la cantidad sea un número
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
                                        quantityproduct = Convert.ToInt32(quantity); //Establezco la cantidad del producto
                                        clientwishes.Add(nameproduct, quantityproduct); //Agrego el producto a la lista de deseos
                                        Console.WriteLine("¿Desea comprar algo más?"); //Le pregunto al usuario si quiere agregar algo más
                                        Console.WriteLine("Opción 1: Sí");
                                        Console.WriteLine("Opción 2: No");
                                        string answer = Console.ReadLine();
                                        if (answer != "1")
                                        {
                                            turnon5 = false; //Si la respuesta es distinta de 1, salgo del ciclo
                                            turnon7 = false;
                                        }
                                    }
                                }
                                else turnon7 = false;
                            }
                            while (turnon7 == true);
                            Client newclient = new Client(name, surname, age2, sex, rut2, birthdate, nationality, clientwishes); //Creo un nuevo cliente
                            first.AddClient(newclient); //Agrego el cliente a la lista de clientes
                        }

                        //Lo mismo que hice para los clientes, se repite para los empleados
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
                            string position = Console.ReadLine(); //Establezco el cargo del empleado
                            //Creo un ciclo para que el sueldo ingresado sea un número
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
                            salary = Convert.ToInt32(Salary); //Establezco el sueldo
                            //Creo un ciclo para que la hora de entrada sea un número y otro para que la hora de salida sea un número
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
                            entry = Convert.ToInt32(Entry); //Establezco la hora de entrada
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
                            exit = Convert.ToInt32(Exit); //Establezco la hora de salida
                            Employee newemployee = new Employee(name, surname, age2, sex, rut2, birthdate, nationality, position, salary, entry, exit); //Creo el empleado
                            first.AddEmployee(newemployee); //Agrego el empleado a la lista de empleados
                        }

                        //Si elige la opción 3, vuelvo a repetir lo anterior, pero esta vez, para los atributos del producto
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

                        //Si elige la opción 4, el usuario debe ingresar el rut del cliente que va a comprar
                        else if (election2 == "4")
                        {
                            //Hago un ciclo para comprobar que el rut sea un número
                            bool turnon4;
                            string Rut;
                            int rut2;
                            do
                            {
                                Console.WriteLine("Ingrese el rut del cliente que va a comprar (sin guión y si termina con k, reemplazar por 0): ");
                                Rut = Console.ReadLine();
                                turnon4 = int.TryParse(Rut, out rut2);
                            }
                            while (!turnon4);
                            rut2 = Convert.ToInt32(Rut); //Establezco el rut del cliente que va a comprar
                            string buy = first.Buy(rut2);
                            Console.WriteLine(buy);
                        }
                        //Si elige la opción 5, hago correr la función comprar que compra todo de una
                        else if (election2 == "5")
                        {
                            string buy=first.Buyall();
                            if (buy == "\nBOLETAS\n\n") //Si no tengo compras en la boleta, aviso que no se pudo realizar ninguna compra
                            {
                                Console.WriteLine("No se pudo realizar ninguna compra");
                            }
                            else Console.WriteLine(buy);
                            if (buy!= "No hay cajeros disponibles") //Si esque no hay cajeros disponibles, NO reseteo las listas de clientes
                            {
                                first.DelateClients(); //En caso de que sí se hagan las compras, reseteo la lista de clientes, ya que ya compraron
                            }
                            Console.WriteLine("¿Desea resetear las boletas ? "); //Le pregunto al usuario si desea resetear las boletas, ya que puede ser que quiera guardas las boletas para distintas compras
                            Console.WriteLine("Opción 1: Sí");
                            Console.WriteLine("Opción 2: No");
                            string delate = Console.ReadLine();
                            if (delate == "1")
                            {
                                first.DelateTickets(); 
                            }
                        }

                        //Si elige la opción 6, hago correr la función para modificar a un empleado
                        else if (election2 == "6")
                        {
                            //Creo un ciclo que se  acaba cuando el usuario quiera dejar de crear empleados
                            bool turnon8 = true;
                            do
                            {
                                //Creo un ciclo para comprobar que el rut ingresado sean números
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
                                rut = Convert.ToInt32(Rut); //Establezc el rut
                                //Creo un ciclo para que el usuario decida cuando dejar de modificar al empleado seleccionado
                                bool turnon9 = true;
                                do
                                {
                                    Console.WriteLine("¿Qué desea modificar?"); //Le pregunto al usuario qué desea modificar
                                    Console.WriteLine("Opción 1: Cargo");
                                    Console.WriteLine("Opción 2: Sueldo");
                                    Console.WriteLine("Opción 3: Horas de trabajo");
                                    string answer = Console.ReadLine();
                                    string change=first.ChangeEmployee(rut, answer);
                                    Console.WriteLine(change);
                                    if (change == "Rut no encontrado\n") turnon9 = false; //Si el rut no lo encuetra, termina el ciclo en el que se le pregunta si quiere modificar algo más del mismo usuario 
                                    else
                                    {
                                        Console.WriteLine("¿Desea modificar algo más del empleado: " + rut + "?");
                                        Console.WriteLine("Opción 1: Sí");
                                        Console.WriteLine("Opción 2: No");
                                        string option2 = Console.ReadLine();
                                        if (option2 != "1") turnon9 = false; //Si no quiere modificar nada más del empleado específico, termino el ciclo
                                    }
                                }
                                while (turnon9==true);
                                Console.WriteLine("¿Desea modificar algo de otro empleado?");
                                Console.WriteLine("Opción 1: Sí");
                                Console.WriteLine("Opción 2: No");
                                string option = Console.ReadLine();
                                if (option != "1")
                                {
                                    turnon8 = false; //Si no quiere modifccar otro empleado, se acaba el ciclo
                                }
                            }
                            while (turnon8 == true);
                        
                         //Si elige la opción 7, salgo al menú principal 
                        }
                        else if (election2 == "7")
                        {
                            turnon2 = false;
                        }

                        //Si no elige ninguna de las opciones, se sale del programa (para terminar, hay que presionar enter, porque tengo un ReadKey() para que se vea el mensaje)
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

                //Si elige la opción 2, genero todo de forma aleatoria
                else if (election == "2")
                {
                    for (int i = 0; i < 15; i++) //Genero 15 clientes de forma aleatoria
                    {
                        Client newclient = first.AddRandomClient(); //Creo el cliente
                        first.AddClient(newclient); //Lo agrego a la lista de clientes
                    }
                    for (int i = 0; i < 7; i++) //Genero 7 empleados de forma aleatoria
                    {
                        Employee newemployee = first.AddRandomEmployee();  //Creo el empleado
                        first.AddEmployee(newemployee); //Lo agrego a la lista de empleados
                    }
                    for (int i = 0; i < 30; i++) //Genero 30 productos de forma aleatoria
                    {
                        Product newproduct = first.AddRandomProduct(); //Creo el producto
                        first.AddProduct(newproduct); //Lo agrego a la lista de productos
                    }
                    //Imprimo en pantalla la información de cada persona y cada producto
                    Console.WriteLine("INFORMACIÓN CLIENTES\n");
                    first.ClientsInformation();
                    Console.WriteLine(" \n");
                    Console.WriteLine("INFORMACIÓN EMPLEADOS\n");
                    first.EmployeesInformation();
                    Console.WriteLine(" \n");
                    Console.WriteLine("INFORMACIÓN PRODUCTOS\n");
                    first.ProductsInformation();
                    Console.WriteLine(" \n");

                    //LLamo a la función comprar
                    Console.WriteLine("¡A COMPRAR!");
                    string buy = first.Buy5(); //Uso el método Buy5, ya que para el BONUS me piden que solo 5 personas compren
                    if (buy== "\nBOLETAS\n\n") //Si no tengo compras en la boleta, aviso que no se pudo realizar ninguna compra
                    {
                        Console.WriteLine("No se pudo realizar ninguna compra");
                    }
                    else Console.WriteLine(buy);
                    if (buy != "No hay cajeros disponibles")
                    {
                        first.DelateClients(); //Si esque se logran realizar las compras, reseteó las listas de clientes
                        Console.WriteLine("INFORMACIÓN PRODUCTOS ACTUALIZADOS\n");
                        first.ProductsInformation();
                    }
                    Console.WriteLine("¿Desea resetear las boletas?"); //Le pregunto al usuario si desea resetear las boletas
                    Console.WriteLine("Opción 1: Sí"); //Si esque quiero seguir comprando de a 5 TENGO que resetear las boletas
                    Console.WriteLine("Opción 2: No");
                    string delate = Console.ReadLine();
                    if (delate == "1")
                    {
                        first.DelateTickets(); //Reseteo las boletas
                    }
                }

                //Si elige la opción 3, salgo del programa
                else if (election == "3")
                {
                    turnon = false;
                }

                //Si elige otra opción que no existe, sale del programa
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
