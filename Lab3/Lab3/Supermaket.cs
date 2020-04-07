using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    //Creo la clase supermercado, que es lo que va a mover mi programa
    class Supermaket
    {
        //Creo el constructor vació de la clase supermercado
        public Supermaket()
        {
        }
        //Creo las listas que almacenan productos, clientes, empleados
        List<Product> products = new List<Product>();
        List<Client> clients = new List<Client>();
        List<Employee> employees = new List<Employee>();

        //Creo un string que almacena las boletas
        string tickets = "BOLETAS\n\n";

        //Creo un método que me imprime la información de cada producto almacenado en la lista products
        public void ProductsInformation()
        {
            foreach (Product i in products)
            {
                Console.WriteLine(i.ProductInformation() + "\n");
            }
        }

        //Creo un método que me imprime la información de cada empleado almacenado en la lista employees
        public void EmployeesInformation()
        {
            foreach (Employee i in employees)
            {
                Console.WriteLine(i.EmployeeInformation() + "\n");
            }
        }

        //Creo un método que me imprime la información de cada cliente almacenado en la lista clients
        public void ClientsInformation()
        {
            foreach (Client i in clients)
            {
                Console.WriteLine(i.ClientInformation() + "\n");
            }
        }

        //Creo método que me agrega un producto a la lista products
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        //Creo método que me agrega un cliente a la lista clients
        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        //Creo método que me agrega un empleado a la lista employees
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        //Creo un método que me permite cambiar el cargo, sueldo y horario de un empleado
        public string ChangeEmployee(int rut, string answer)
        {
            string employeeInformation="";
            int contador = 0;
            foreach (Employee i in employees)
            {
                if (i.Rut == rut) //En primer lugar le pido el rut
                {
                    if (answer == "1") //Si elige la opción 1 selecciono nuevo cargo
                    {
                        Console.WriteLine("Ingrese nuevo cargo");
                        string newposition = Console.ReadLine();
                        i.Position = newposition;
                    }
                    else if (answer == "2") //Si elige la opción 2 selecciono nuevo sueldo
                    {
                        bool turnon;
                        string Salary;
                        int salary;
                        do
                        {
                            Console.WriteLine("Ingrese nuevo sueldo del empleado: ");
                            Salary = Console.ReadLine();
                            turnon = int.TryParse(Salary, out salary); //Compruebo que lo ingresado sea un número
                        }
                        while (!turnon); //Le va a preuntar al usuario el dato hasta que ingrese un número
                        salary = Convert.ToInt32(Salary);
                        i.Salary = salary;
                    }
                    else if (answer == "3") //Si elige la opción 3 selecciono nuevo horario de entrada y de salida
                    {
                        bool turnon;
                        string Entry;
                        int newentry;
                        do
                        {
                            Console.WriteLine("Ingrese nuevo horario de entrada: ");
                            Entry = Console.ReadLine();
                            turnon = int.TryParse(Entry, out newentry); //Reviso que lo ingresado sea un número
                        }
                        while (!turnon);//Le va a preuntar al usuario el dato hasta que ingrese un número
                        newentry = Convert.ToInt32(Entry);
                        i.Entry = newentry;

                        bool turnon2;
                        string Exit;
                        int newexit;
                        do
                        {
                            Console.WriteLine("Ingrese nuevo horario de salida: ");
                            Exit = Console.ReadLine();
                            turnon2 = int.TryParse(Exit, out newexit);//Reviso que lo ingresado sea un número
                        }
                        while (!turnon2);//Le va a preuntar al usuario el dato hasta que ingrese un número
                        newexit = Convert.ToInt32(Exit);
                        i.Exit = newexit;
                    }
                    employeeInformation += i.EmployeeInformation(); //Agrego la información del empleado encontrado
                }
                else contador += 1; //Voy sumando de a 1 al contador cada vez que no encuentre al empleado
              
            }
            if (contador == employees.Count) //Cuando el contador es igual a la cantidad de empleados, es porque el rut ingresado no existe
            {
                return "Rut no encontrado\n"; //Si no encuentro el rut devuelvo Rut no encontrado
            }
            else
            {
                return "EMPLEADO MODIFICADO: " + employeeInformation + "\n"; //Devuelve la información del empleado con los respectivos cambios
            }
        }

        //Creo la instancia para generar valores aleatorios
        static Random rnd = new Random();

        //Creo un método que me devuelve un cajero aleatorio que esté trabajando en el horario de la compra
        public string RandomSeller()
        {
            DateTime now = DateTime.Now; //Calculo la fecha y hora de compra
            int hour = now.Hour; //Calculo la hora de compra
            List<string> possibleSeller = new List<string>(); //Creo una lista que almacena a los posibles vendedores
            foreach (Employee e in employees) //Recorro a todos los empleados que existen 
            {
                if ((e.Position == "Cajero" || e.Position == "cajero") && e.Entry <= hour && e.Exit > hour)//Establezco que el que atienda al cliente sea un cajero y que esté dentro de su horario
                {
                    possibleSeller.Add(e.EmployeeInformation()); //Agrego el posible vendedor a la lista
                }
            }
            int index = rnd.Next(possibleSeller.Count);
            if (possibleSeller.Count == 0) return "No hay cajeros disponibles"; //Retorno si esque no hay ningun empleado que cumpla con las características
            else return possibleSeller[index];//Si es

        }

        int ticketnumber = 0; //Creo una variable para ir poniéndole número a las boletas

        //Creo el método comprar
        public string Buy()
        {
            if (RandomSeller() == "No hay cajeros disponibles") //Cuando no hay cajeros disponiles
            {
                return "No hay cajeros disponibles"; //Devuelvo que no hay cajeros disponibles
            }
            else
            {
                foreach (Client a in clients) //Recorro cada cliente
                {
                    string shoppingcart = ""; //Creo una variable para su carro de compras
                    string seller = RandomSeller(); //Elijo un vendedor al azar
                    int totalprice = 0; //Creo una variable para almacenar el precio total de cada cliente
                    foreach (KeyValuePair<string, int> i in a.Clientwishes) //Recorro cada deseo de compra que tiene el cliente
                    {
                        int quantity = i.Value; //Creo la variable cantidad que es la cantidad que desea el cliente
                        int price; //Creo la variable precio
                        string nameproduct = i.Key.ToLower(); //Paso el nombre del producto que desea el cliente a minúsculas
                        int counter = 0; //Creo un contador que se le va sumando 1 si esque el producto es encontrado
                        foreach (Product p in products)
                        {
                            if (quantity == 0) continue; //Si la cantidad que deseo de un producto es 0, simplemente continúo
                            else
                            {
                                if (p.Nameproduct.ToLower() == nameproduct && p.Stock >= quantity) //Cuando los nombres del producto coinciden y la stock disponible alcanza
                                {
                                    price = quantity * p.Price; //Multiplico la cantidad comprada por el precio unitario
                                    totalprice += price; //Le sumo al precio total de la boleta el precio gastado en el producto
                                    shoppingcart += "Producto: " + i.Key + ", marca: " + p.Brand + ", cantidad: " + quantity + ", precio unitario: " + p.Price + ", precio total: " + price + "\n"; //Le agrego al carro de compras los datos relevantes
                                    p.Stock -= quantity; //Le resto al stock disponible la cantidad comprada
                                    quantity = 0; //La cantidad deseada pasa a ser 0
                                }
                                else if (p.Nameproduct.ToLower() == nameproduct && p.Stock < quantity && p.Stock > 0) //Cuando los nombres coinciden y el stock es menor a la cantidad deseada, pero mayor a 0
                                {
                                    price = p.Stock * p.Price; //Multiplico la cantidad que compro (que va a ser igual al stock disponible) por el precio unitario
                                    totalprice += price; //Le sumo al precio total de la boleta el precio gastado en el producto
                                    shoppingcart += "Producto: " + i.Key + ", marca: " + p.Brand + ", cantidad: " + p.Stock + ", precio unitario: $" + p.Price + ", precio total: $" + price + "\n"; //Le agrego al carro de compras los datos relevantes
                                    quantity -= p.Stock; //Le resto a la cantidad deseada lo que compré (que es el stock disponible)
                                    p.Stock -= p.Stock; //El stock disponible pasa a ser 0
                                }
                                else counter += 1; //Si no encuentro el producto, le agrego al contador 1
                            }
                        }
                        if (counter == products.Count) //Si el contador es igual a la cantidad de productos que hay
                        {
                            shoppingcart += "Producto: " + i.Key + " no está en tienda\n"; //Se le agrega al carro que el producto no estaba en la tienda
                        }
                        else if (quantity != 0)
                        {
                            shoppingcart += "No se pudieron comprar " + quantity + " " + i.Key + "\n"; //Se le agrega al carro la cantidad de productos que no se pudieron comprar
                        }
                    }
                    DateTime now = DateTime.Now; //Establezco la fecha y hora de la compra
                    if (shoppingcart == "") continue; //Si la persona no va a comprar nada, no la agrego a la boleta
                    else
                    {
                        ticketnumber += 1; //Agrego el número de la boleta
                        tickets += "BOLETA NÚMERO: " + ticketnumber + "\n" + "INFORMACIÓN CLIENTE: " + a.ClientInformation() + "\nCOMPRAS: \n" + shoppingcart + "VENDEDOR: " + seller + "\nPRECIO TOTAL: $" + totalprice + "\nFECHA Y HORA: " + now + "\n\n"; //Le agrego a las boletas la boleta del comprador a
                    }
                }
                return tickets; //Devuelvo los tickets
            }
        }

        //Creo el método para eliminar los elementos creados en las listas
        public void DelateElements()
        {
            products.Clear();
            employees.Clear();
            clients.Clear();
        }

        //Creo método para reseatear las boletas
        public void DelateTickets()
        {
            tickets = "BOLETAS\n\n";
            ticketnumber = 0;
        }

        //BONUS
        //Creo método que genera el género de forma aleatoria
        public string getRandomSex()
        {
            string[] possibleSex = new string[]
            {
                "Femenino", "Masculino"
            };
            return possibleSex[rnd.Next(possibleSex.Length)];
        }

        //Creo método que genera nombres de forma aleatoria y recibe un género
        public string getRandomName(string sex)
        {
            if (sex== "Femenino")
            {
                string[] possibleFirstNames = new string[] //Creo lista con posibles nombres de mujer
                {"Emma","Olivia","Sofia","Isabel","Ava","Mia","Emilia","Francisca","María","Charlotte","Jesús","Andrea","Antonia","Elizabeth","Amelia","Evelyn","Agustina","Chloe","Victoria","Bernardita",
                 "Grace","Zoey","Natalie","Rosario","Florencia","Alejandra","Lily","Hannah","Catalina","Carmen","Isidora","Trinidad","Josefina","Amalia","Andrea","Paula","Paulina","Loreto","Patricia","Zara","Javiera","Margarita","Antonia","Mijal","Valentina","Ignacia"};
                return possibleFirstNames[rnd.Next(possibleFirstNames.Length)];
            }
            else
            {
                string[] possibleFirstNames = new string[] //Creo lista con posibles nombres de hombre
                {"Walter","José","Tomás","Juan","Andrés","Miguel","Germán","Ignacio","Andreas","Manuel","Federico","Maximiliano","Felipe","Carlos","Martín","Sebastián","Nicolás" };
                return possibleFirstNames[rnd.Next(possibleFirstNames.Length)];
            }
        }

        //Creo método que genera apellidos de forma aleatoria
        public string getRandomLastName()
        {
            string[] possibleLastNames = new string[] //Creo lista con posibles apellidos
            {"Aspillaga", "Binder", "Correa", "Dominguez", "Errazuriz", "Fontanet", "Guevara", "Herrera", "Izquierdo", "Jimenez", "Kast", "Lira", "Medina","Nadal", "Opazo", "Pérez", "Quiroga", "Rodríguez", "Silva", "Turner", "Urrejola", "Valdivia", "Wolff", "Yañez", "Zirpel"};
            return possibleLastNames[rnd.Next(possibleLastNames.Length)];
        }

        //Creo método que genera edad de forma aleatoria
        public int getRandomClientAge()
        {
            return rnd.Next(8, 96); //Los clientes tienen desde 8 a 95 años
        }

        public int getRandomEmployeeAge()
        {
            return rnd.Next(18, 71); //Los empleados tienen desde 18 a 70 años
        }

        //Creo método que genera rut de forma aleatoria
        public int getRandomRut()
        {
            string rut = "";
            for (int i = 0; i < 9; i++) //Se consideran ruts de 9 dígitos
            {
                rut += rnd.Next(0, 10);
            }
            int rut2 = Convert.ToInt32(rut);
            return rut2;
        }

        //Creo método que genera nacionalidad de forma aleatoria
        public string getRandomNationality()
        {
            string[] possibleNationality = new string[] //Creo lista posibles nacionalidades
            {
                "Chilena", "Venezolana", "Peruana", "Argentina", "Alemana", "Italiana", "Española", "China", "Boliviana", "Japonesa", "Francesa","Suiza"
            };
            return possibleNationality[rnd.Next(possibleNationality.Length)];
        }

        //Creo método que genera la fecha de nacimiento de forma aleatoria
        public string getBirthDate()
        {
            string day = "";
            day += rnd.Next(0, 31); //Posibles días (Considero que cada mes tiene 30 días)
            string[] possibleMonth = new string[] //Posibles meses
           {
                "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11","12"
           };

            string year = "";
            year += rnd.Next(1990, 2013); //Posibles años

            string birthdate = "";
            birthdate += day;
            birthdate += "/";
            birthdate += possibleMonth[rnd.Next(possibleMonth.Length)];
            birthdate += "/";
            birthdate += year;
            return birthdate; 
        }

        //Creo método que me genera el cargo de forma aleatoria
        public string getRandomPosition()
        {
            string[] possiblePosition = new string[] //Creo posibles cargos
            {
                "Gerente", "Cajero", "Auxiliar", "Empaquetador", "Limpiador", "Cajero", "Cajero","Cajeros" //Repito cajeros, ya que salía mucho en la simulación que no habían cajeros disponibles
            };
            return possiblePosition[rnd.Next(possiblePosition.Length)];
        }

        //Creo método que me crea un salario de forma aleatoria según el cargo
        public int getRandomSalary(string randomPosition) 
        {
            if (randomPosition == "Gerente")
            {
                return rnd.Next(2000000, 2500001);
            }
            else if (randomPosition == "Cajero")
            {
                return rnd.Next(800000, 1200001);
            }
            else if (randomPosition == "Auxiliar")
            {
                return rnd.Next(600000, 800001);
            }
   
            else if (randomPosition == "Empaquetador")
            {
                return rnd.Next(500000, 600001);
            }
            else if (randomPosition == "Limpiador")
            {
                return rnd.Next(400000, 600001);
            }
            else
            {
                return rnd.Next(1000000, 2000001);
            }
        }

        //Creo método que me genera de forma aleatoria la hora de entrada según cargo
        public int getRandomEntry(string randomPosition)
        {
            if (randomPosition == "Gerente")
            {
                return 9;
            }
            else if (randomPosition == "Cajero" || randomPosition == "Auxiliar")
            {
                int[] possibleWorkingHours = new int[]
            {
                7,15
            };
                return possibleWorkingHours[rnd.Next(possibleWorkingHours.Length)];
            }

            else if (randomPosition == "Empaquetador")
            {
                return 10;
            }
            else if (randomPosition == "Limpiador")
            {
                int[] possibleWorkingHours = new int[]
            {
                8,13,20
            };
                return possibleWorkingHours[rnd.Next(possibleWorkingHours.Length)];
            }
            else
            {
                return 9;
            }
        }

        //Creo método que me genera de forma aleatoria la hora de salida según cargo
        public int getRandomExit(string randomPosition, int randomEntry)
        {
            if (randomPosition == "Gerente")
            {
                return 20;
            }
            else if (randomPosition == "Cajero" || randomPosition == "Auxiliar")
            {
                if (randomEntry == 7) return 16;
                else return 24;
            }

            else if (randomPosition == "Empaquetador")
            {
                return 21;
            }
            else if (randomPosition == "Limpiador")
            {
                if (randomEntry == 8) return 11;
                else if (randomEntry == 13) return 16;
                else  return 23;
            }
            else
            {
                return 23;
            }
        }

        //Creo método que me genera de forma aleatoria el nombre del producto
        public string getRandomNameProduct()
        {
            string[] possibleLastNames = new string[]
            {
                "Manzanas", "Zanahorias", "Duraznos", "Naranjas", "Ramitas", "Papas fritas", "Cocacola", "Sprite", "Fanta", "Jugo de naranja", "Jugo de Frutilla", "Jugo de mango", "Pepsi", "Canada Dry", "Crush","Galletas", "Cheetos", "Doritos", "Cigarros", "Energizante",
                "Pisco", "Vodka", "Barrita de cereal", "Dulces", "Pan", "Mermelada", "Apío", "Limones","Pretzel","Chicles","Chip","Arroz","Carne","Queso","Jamón","Donut"
            };
            return possibleLastNames[rnd.Next(possibleLastNames.Length)];
        }

        public string getRandomType(string nameproduct)
        {
            if (nameproduct == "Manzanas" || nameproduct == "Naranjas" || nameproduct == "Duraznos" || nameproduct == "Zanahorias" || nameproduct == "Apío" || nameproduct == "Limones")
            {
                return "Frutas y verduras";
            }
            else if (nameproduct == "Ramitas" || nameproduct == "Papas fritas" || nameproduct == "Galletas" || nameproduct == "Cheetos" || nameproduct == "Doritos" || nameproduct == "Barritas de cereal" || nameproduct == "Dulces")
            {
                return "Coaciones";
            }
            else if (nameproduct == "Cocacola" || nameproduct == "Fanta" || nameproduct == "Sprite" || nameproduct == "Jugo de naranja" || nameproduct == "Jugo de Frutilla" || nameproduct == "Jugo de mango" || nameproduct == "Pepsi" || nameproduct == "Canada Dry" || nameproduct == "Crush")
            {
                return "Bebestibles";
            }
            else if (nameproduct == "Energizante")
            {
                return "Energizantes";
            }
            else if (nameproduct == "Vodka" || nameproduct == "Pisco")
            {
                return "Alcohol";
            }
            else if (nameproduct == "Cigarros")
            {
                return "Vicios";
            }
            else
            {
                return "Otros";
            }

        }

        //Creo método que genera precio de forma aleatoria según el tipo
        public int getRandomPrice(string type)
        {
            if (type == "Frutas y verduras")
            {
                return rnd.Next(200, 501);
            }
            else if (type == "Colaciones")
            {
                return rnd.Next(500, 1501);
            }
            else if (type == "Bebestibles")
            {
                return rnd.Next(1000, 1501);
            }
            else if (type == "Energizantes")
            {
                return rnd.Next(1000, 2001);
            }
            else if (type == "Alcohol")
            {
                return rnd.Next(5000, 10001);
            }
            else if (type == "Vicios")
            {
                return rnd.Next(2000, 3001);
            }
            else
            {
                return rnd.Next(1500, 3001);
            }
        }

        //Creo método que genera marcas de forma aleatoria según el tipo
        public string getRandomBrand(string type)
        {
            if (type == "Frutas y verduras")
            {
                return "Dole";
            }
            else if (type == "Colaciones")
            {
                string[] possibleBrands = new string[]
            {
                "Kryspo", "Everscip", "Tika", "Gran Cereal", "Soul Bar"
            };
                return possibleBrands[rnd.Next(possibleBrands.Length)];
            }
            else if (type == "Bebestibles")
            {
                string[] possibleBrands = new string[]
            {
                "CCU", "Watts", "Livean", "PepsiCo"
            };
                return possibleBrands[rnd.Next(possibleBrands.Length)];
            }
            else if (type == "Energizantes")
            {
                string[] possibleBrands = new string[]
            {
                "RedBull", "Monster"
            };
                return possibleBrands[rnd.Next(possibleBrands.Length)];
            }
            else if (type == "Alcohol")
            {
                string[] possibleBrands = new string[]
            {
                "Absolut", "Alto del Carmen", "Smirnoff", "Capel"
            };
                return possibleBrands[rnd.Next(possibleBrands.Length)];
            }
            else if (type == "Vicios")
            {
                string[] possibleBrands = new string[]
            {
                "Palmal Click", "Lucky Strike", "Kent"
            };
                return possibleBrands[rnd.Next(possibleBrands.Length)];
            }
            else
            {
                return "Elaboración propia";
            }
        }

        //Creo metodo que genera el Stock de forma aleatoria
        public int getRandomStock()
        {
            return rnd.Next(1, 21); //Stock máximo 21 elementos
        }


        //Creo método que me genera la lista de deseos de los clientes de forma aleatoria
        public Dictionary<string,int> getRandomClientwishes()
        {
            Dictionary<string, int> randomclientwishes = new Dictionary<string, int>(); //Creo diccionario de lista de deseo
            int numberproducts = rnd.Next(0, 6); //Genero una cantidad de productos interés de forma aleatoria (máximo 5 productos, si no quiere comprar, 0 productos
            for (int i = 0; i < numberproducts; i++)
            {
                string nameproduct = getRandomNameProduct(); //Genero el nombre del producto de forma aleatoria
                int quantityproduct = rnd.Next(1, 6); //Y la cantidad que quiero de ese producto (máximo 5 por producto)
                if (randomclientwishes.ContainsKey(nameproduct)) //Si ya tengo ese producto, continúo 
                {
                    continue;
                }
                else
                {
                    randomclientwishes.Add(nameproduct, quantityproduct); //Si no lo tengo, lo agrego al diccionario
                }
            }
            return randomclientwishes;
        }

        //Creo método que agrega cliente aleatorio
        public Client AddRandomClient()
        {
            string surname = getRandomLastName();
            int age = getRandomClientAge();
            string sex = getRandomSex();
            string name = getRandomName(sex);
            int rut = getRandomRut();
            string birthdate = getBirthDate();
            string nationality = getRandomNationality();
            Dictionary<string, int> clientwishes = getRandomClientwishes();
            Client newclient = new Client(name, surname, age, sex, rut, birthdate, nationality, clientwishes); 
            return newclient;
        }

        //Creo método que agrega el empleado aleatorio
        public Employee AddRandomEmployee()
        {
            string surname = getRandomLastName();
            int age = getRandomEmployeeAge();
            string sex = getRandomSex();
            string name = getRandomName(sex);
            int rut = getRandomRut();
            string birthdate = getBirthDate();
            string nationality = getRandomNationality();
            string position = getRandomPosition();
            int salary = getRandomSalary(position);
            int entry = getRandomEntry(position);
            int exit = getRandomExit(position,entry);
            Employee newemployee = new Employee(name, surname, age, sex, rut, birthdate, nationality, position, salary, entry, exit);
            return newemployee;
        }

        //Creo método que agrega el producto aleatorio
        public Product AddRandomProduct()
        {
            string nameproduct = getRandomNameProduct();
            string type = getRandomType(nameproduct);
            int price = getRandomPrice(type);
            int stock = getRandomStock();
            string brand = getRandomBrand(type);
            Product newproduct = new Product(nameproduct, price, brand, stock, type);
            return newproduct;
        }
    }
}
