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

        
        //PARA CREAR LAS COSAS DE FORMA ALEATORIA
        public string getRandomName()
        {
            string[] possibleFirstNames = new string[]
            {
                "Emma","Olivia","Sophia","Isabella","Ava","Mia","Emily","Abigail","Madison","Charlotte","Harper","Sofia","Avery","Elizabeth","Amelia","Evelyn","Ella","Chloe","Victoria","Aubrey","Grace","Zoey","Natalie","Addison","Lillian","Brooklyn","Lily","Hannah","Layla","Scarlett","Aria","Zoe","Samantha","Anna","Leah","Audrey","Ariana","Allison","Savannah","Arianna","Camila","Penelope","Gabriella","Claire","Aaliyah","Sadie","Riley","Skylar","Nora","Sarah","Hailey","Kaylee","Paisley","Kennedy","Ellie","Peyton","Annabelle","Caroline","Madelyn","Serenity","Aubree","Lucy","Alexa","Alexis","Nevaeh","Stella","Violet","Genesis","Mackenzie","Bella","Autumn","Mila","Kylie","Maya","Piper","Alyssa","Taylor","Eleanor","Melanie","Naomi","Faith","Eva","Katherine","Lydia","Brianna","Julia","Ashley","Khloe","Madeline","Ruby","Sophie","Alexandra","London","Lauren","Gianna","Isabelle",
                "Alice","Vivian","Hadley","Jasmine","Morgan","Kayla","Cora","Bailey","Kimberly","Reagan","Hazel","Clara","Sydney","Trinity","Natalia","Valentina","Rylee","Jocelyn","Maria","Aurora","Eliana","Brielle","Liliana","Mary","Elena","Molly","Makayla","Lilly","Andrea","Quinn","Jordyn","Adalynn","Nicole","Delilah","Kendall","Kinsley","Ariel","Payton","Paige","Mariah","Brooke","Willow","Jade","Lyla","Mya","Ximena","Luna","Isabel","Mckenzie","Ivy","Josephine","Amy","Laila","Isla","Eden","Adalyn","Angelina","Londyn","Rachel","Melody","Juliana","Kaitlyn","Brooklynn","Destiny","Emery","Gracie","Norah","Emilia","Reese","Elise","Sara","Aliyah","Margaret","Catherine","Vanessa","Katelyn","Gabrielle","Arabella","Valeria","Valerie","Adriana","Everly","Jessica","Daisy","Makenzie","Summer","Lila","Rebecca","Julianna","Callie","Michelle","Ryleigh","Presley","Alaina","Angela","Alina",
                "Harmony","Rose","Athena","Emerson","Adelyn","Alana","Hayden","Izabella","Cali","Marley","Esther","Fiona","Stephanie","Cecilia","Kate","Kinley","Jayla","Genevieve","Alexandria","Eliza","Kylee","Alivia","Giselle","Arya","Alayna","Leilani","Adeline","Jennifer","Tessa","Ana","Finley","Melissa","Daniela","Aniyah","Daleyza","Keira","Charlie","Lucia","Hope","Gabriela","Mckenna","Brynlee","Parker","Lola","Amaya","Miranda","Maggie","Anastasia","Leila","Lexi","Georgia","Kenzie","Iris","Jacqueline","Jordan","Cassidy","Vivienne","Camille","Noelle","Adrianna","Teagan","Josie","Juliette","Annabella","Allie","Juliet","Kendra","Sienna","Brynn","Kali","Maci","Danielle","Haley","Jenna","Raelynn","Delaney","Paris","Alexia","Lyric","Gemma","Lilliana","Chelsea","Angel","Evangeline","Ayla","Kayleigh","Lena","Katie","Elaina","Olive","Madeleine","Makenna","Dakota","Elsa","Nova","Nadia",
                "Alison","Kaydence","Journey","Jada","Kathryn","Shelby","Nina","Elliana","Diana","Phoebe","Alessandra","Eloise","Nyla","Skyler","Madilyn","Adelynn","Miriam","Ashlyn","Amiyah","Megan","Amber","Rosalie","Annie","Lilah","Charlee","Amanda","Ruth","Adelaide","June","Laura","Daniella","Mikayla","Raegan","Jane","Ashlynn","Kelsey","Erin","Christina","Joanna","Fatima","Allyson","Talia","Mariana","Sabrina","Haven","Ainsley","Cadence","Elsie","Leslie","Heaven","Arielle","Maddison","Alicia","Briella","Lucille","Sawyer","Malia","Selena","Heidi","Kyleigh","Harley","Kira","Lana","Sierra","Kiara","Paislee","Alondra","Daphne","Carly","Jaylah","Kyla","Bianca","Baylee","Cheyenne","Macy","Camilla","Catalina","Gia","Vera","Skye","Aylin","Sloane","Myla","Yaretzi","Giuliana","Macie","Veronica","Esmeralda","Lia","Averie","Addyson","Kamryn","Mckinley","Ada","Carmen","Mallory","Jillian",
                "Ariella","Rylie","Sage","Abby", "Matthew", "Scarlet","Logan","Tatum","Bethany","Dylan","Elle","Jazmin","Aspen","Camryn","Malaysia","Haylee","Nayeli","Gracelyn","Kamila","Helen","Marilyn","April","Carolina","Amina","Julie","Raelyn","Blakely","Rowan","Angelique","Miracle","Emely","Jayleen","Kennedi","Amira","Briana","Gwendolyn","Justice","Zara","Aleah","Itzel","Bristol","Francesca","Emersyn","Aubrie","Karina","Nylah","Kelly","Anaya","Maliyah","Evelynn","Ember","Melany","Angelica","Jimena","Madelynn","Kassidy","Tiffany","Kara","Jazmine","Jayda","Dahlia","Alejandra","Sarai","Annabel","Holly","Janelle","Braelyn","Gracelynn","River","Viviana","Serena","Brittany","Annalise","Brinley","Madisyn","Eve","Cataleya","Joy",
                "Caitlyn","Anabelle","Emmalyn","Journee","Celeste","Brylee","Luciana","Marlee","Savanna","Anya","Marissa","Jazlyn","Zuri","Kailey","Crystal","Michaela","Lorelei","Guadalupe","Madilynn","Maeve","Hanna","Priscilla","Kyra","Lacey","Nia","Charley","Jamie","Juniper","Cynthia","Karen","Sylvia","Phoenix","Aleena","Caitlin","Felicity","Elisa","Julissa","Rebekah","Evie","Helena","Imani","Karla","Millie","Lilian","Raven","Harlow","Leia","Ryan","Kailyn","Lillie","Amara","Kadence","Lauryn","Cassandra","Kaylie","Madalyn","Anika","Hayley","Bria","Colette","Henley","Amari","Regina","Alanna","Azalea","Fernanda","Jaliyah","Anabella","Adelina","Lilyana","Skyla","Addisyn","Zariah","Bridget","Braylee","Monica","Jayden","Leighton","Gloria","Johanna","Addilyn","Danna","Selah","Aryanna","Kaylin","Aniya","Willa","Angie","Kaia","Kaliyah","Anne","Tiana","Charleigh","Winter","Danica","Alayah",
                "Aisha","Bailee", "Addylynn", "Kenley","Aileen","Lexie","Janiyah","Braelynn","Liberty","Katelynn","Mariam","Sasha","Lindsey","Montserrat","Cecelia","Mikaela","Kaelyn","Rosemary","Annika","Tatiana","Cameron","Marie","Dallas","Virginia","Liana","Matilda","Freya","Lainey","Hallie","Jessie","Audrina","Blake","Hattie","Monserrat","Kiera","Laylah","Greta","Alyson","Emilee","Maryam","Melina","Dayana","Jaelynn","Beatrice","Frances","Elisabeth","Saige","Kensley","Meredith","Aranza","Rosa","Shiloh","Charli","Elyse","Alani","Mira","Lylah","Linda","Whitney","Alena","Jaycee","Joselyn","Ansley","Kynlee","Miah","Tenley","Breanna","Emelia","Maia","Edith","Pearl","Anahi","Coraline","Samara","Demi","Chanel","Kimber","Lilith","Malaya","Jemma","Myra","Bryanna","Laney","Jaelyn","Kaylynn","Kallie","Natasha","Nathalie","Perla","Amani","Lilianna","Madalynn","Blair","Elianna","Karsyn","Lindsay","Elaine",
                "Dulce","Ellen","Erica","Maisie","Renata","Kiley","Marina","Remi","Emmy", "Noah", "Ivanna","Amirah","Livia","Amelie","Irene","Mabel","Milan","Armani","Cara","Ciara","Kathleen","Jaylynn","Caylee","Lea","Erika","Paola","Alma","Courtney","Mae","Kassandra","Maleah","Remington","Leyla","Mina","Ariah","Christine","Jasmin","Kora","Chaya","Karlee","Lailah","Mara","Jaylee","Raquel","Siena","Lennon","Desiree","Hadassah","Kenya","Aliana","Wren","Amiya","Isis","Zaniyah","Avah","Amia","Cindy","Eileen","Kayden","Madyson","Celine","Aryana","Everleigh","Isabela","Reyna","Teresa","Jolene","Marjorie","Myah","Clare","Claudia","Leanna","Noemi","Corinne","Simone","Alia","Brenda","Dorothy","Emilie","Elin","Tori","Martha","Ally","Arely","Leona","Patricia","Sky","Thalia","Carolyn","Emory","Nataly","Paityn","Shayla","Averi","Jazlynn","Margot","Lisa","Lizbeth","Nancy","Deborah","Ivory","Khaleesi","Elliot",
                "Meadow","Yareli","Farrah","Milania","Janessa","Milana","Zoie","Adele","Clarissa","Hunter","Lina","Oakley","Sariah","Emmalynn","Galilea","Hailee","Halle","Sutton","Giana","Thea","Denise","Naya","Kristina","Liv","Nathaly","Wendy","Aubrielle","Brenna","Carter","Danika","Monroe","Celia","Dana","Jolie","Taliyah","Casey","Miley","Yamileth","Jaylene","Saylor","Joyce","Milena","Zariyah","Sandra","Ariadne","Aviana","Mollie","Cherish","Alaya","Asia","Nola","Penny","Dixie","Marisol","Adrienne","Rylan","Kori","Kristen","Aimee","Esme","Laurel","Aliza","Roselyn","Sloan","Lorelai","Jenny","Katalina","Lara","Amya","Ayleen","Aubri","Ariya","Carlee","Iliana","Magnolia","Aurelia","Elliott","Evalyn","Natalee","Rayna","Heather","Collins","Estrella","Rory","Hana","Kenna","Jordynn","Rosie","Aiyana","America","Angeline","Janiya","Jessa","Tegan","Susan","Emmalee","Taryn","Temperance","Alissa", "Kenia","Abbigail","Briley","Kailee",
                "Payge","Rainy","Reeva","Rhonda","Rhyleigh","Rivers","Rivkah","Rue","Rumaysa","Rylann","Samanvi","Sameera","Sammi","Shamya","Shaylyn","Sheily","Sidra"
            };
            return possibleFirstNames[rnd.Next(possibleFirstNames.Length)];
        }
        public string getRandomLastName()
        {
            string[] possibleLastNames = new string[]
            {
                "Aspillaga", "Binder", "Correa", "Dominguez", "Errazuriz", "Fontanet", "Guevara", "Herrera", "Izquierdo", "Jimenez", "Kast", "Lira", "Medina",
                "Nadal", "Opazo", "Pérez", "Quiroga", "Rodríguez", "Silva", "Turner", "Urrejola", "Valdivia", "Wolff", "Yañez", "Zirpel"
            };
            return possibleLastNames[rnd.Next(possibleLastNames.Length)];
        }
        public int getRandomAge()
        {
            return rnd.Next(8, 95);
        }

        public int getRandomRut()
        {
            string rut = "";
            for (int i = 0; i < 9; i++)
            {
                rut += rnd.Next(0, 9);
            }
            int rut2 = Convert.ToInt32(rut);
            return rut2;
        }
        public string getRandomSex()
        {
            string[] possibleSex = new string[]
            {
                "Femenino", "Masculino"
            };
            return possibleSex[rnd.Next(possibleSex.Length)];
        }

        public string getRandomNationality()
        {
            string[] possibleNationality = new string[]
            {
                "Chilena", "Venezolana", "Peruana", "Argentina", "Alemana", "Italiana", "Española", "China", "Boliviana", "Japonesa", "Francesa","Suiza"
            };
            return possibleNationality[rnd.Next(possibleNationality.Length)];
        }


        public string getBirthDate()
        {
            string day = "";
            day += rnd.Next(0, 30);
            string[] possibleMonth = new string[]
           {
                "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11","12"
           };

            string year = "";
            year += rnd.Next(1990, 2000);

            string birthdate = "";
            birthdate += day;
            birthdate += "/";
            birthdate += possibleMonth[rnd.Next(possibleMonth.Length)];
            birthdate += "/";
            birthdate += year;
            return birthdate;

        }

        public string getRandomPosition()
        {
            string[] possiblePosition = new string[]
            {
                "Gerente", "Cajero", "Auxiliar", "Reponedor", "Empaquetador", "Limpiador"
            };
            return possiblePosition[rnd.Next(possiblePosition.Length)];
        }

        public int getRandomSalary(string randomPosition)
        {
            if (randomPosition == "Gerente")
            {
                return rnd.Next(2000000, 2500000);
            }
            else if (randomPosition == "Cajero")
            {
                return rnd.Next(800000, 1200000);
            }
            else if (randomPosition == "Auxiliar")
            {
                return rnd.Next(600000, 800000);
            }
            else if (randomPosition == "Reponedor")
            {
                return rnd.Next(800000, 1200000);
            }
            else if (randomPosition == "Empaquetador")
            {
                return rnd.Next(500000, 600000);
            }
            else if (randomPosition == "Limpiador")
            {
                return rnd.Next(400000, 600000);
            }
            else
            {
                return rnd.Next(1000000, 2000000);
            }
        }

        public int getRandomEntry(string randomPosition)
        {
            if (randomPosition == "Gerente")
            {
                return 9;
            }
            else if (randomPosition == "Cajero" || randomPosition == "Reponedor" || randomPosition == "Auxiliar")
            {
                int[] possibleWorkingHours = new int[]
            {
                8,15
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

        public int getRandomExit(string randomPosition)
        {
            if (randomPosition == "Gerente")
            {
                return 20;
            }
            else if (randomPosition == "Cajero" || randomPosition == "Reponedor" || randomPosition == "Auxiliar")
            {
                int[] possibleWorkingHours = new int[]
            {
                16,23
            };
                return possibleWorkingHours[rnd.Next(possibleWorkingHours.Length)];
            }

            else if (randomPosition == "Empaquetador")
            {
                return 21;
            }
            else if (randomPosition == "Limpiador")
            {
                int[] possibleWorkingHours = new int[]
            {
                11,16,23
            };
                return possibleWorkingHours[rnd.Next(possibleWorkingHours.Length)];
            }
            else
            {
                return 9;
            }
        }
        public string getRandomNameProduct()
        {
            string[] possibleLastNames = new string[]
            {
                "Manzanas", "Zanahorias", "Duraznos", "Naranjas", "Ramitas", "Papas fritas", "Cocacola", "Sprite", "Fanta", "Jugo de naranja", "Jugo de Frutilla", "Jugo de mango", "Pepsi", "Canada Dry", "Crush","Galletas", "Cheetos", "Doritos", "Cigarros", "Energizante",
                "Pisco", "Vodka", "Barrita de cereal", "Dulces", "Pan", "Mermelada"
            };
            return possibleLastNames[rnd.Next(possibleLastNames.Length)];
        }

        public string getRandomType(string nameproduct)
        {
            if (nameproduct == "Manzanas" || nameproduct == "Naranjas" || nameproduct == "Duraznos" || nameproduct == "Zanahorias")
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


        public int getRandomPrice(string type)
        {
            if (type == "Frutas y verduras")
            {
                return rnd.Next(200, 500);
            }
            else if (type == "Colaciones")
            {
                return rnd.Next(500, 1500);
            }
            else if (type == "Bebestibles")
            {
                return rnd.Next(1000, 1500);
            }
            else if (type == "Energizantes")
            {
                return rnd.Next(1000, 2000);
            }
            else if (type == "Alcohol")
            {
                return rnd.Next(5000, 10000);
            }
            else if (type == "Vicios")
            {
                return rnd.Next(2000, 3000);
            }
            else
            {
                return rnd.Next(1500, 3000);
            }
        }

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

        public int getRandomStock()
        {
            return rnd.Next(0, 100);
        }

        public Dictionary<string,int> getRandomClientwishes()
        {
            Dictionary<string, int> randomclientwishes = new Dictionary<string, int>();
            int numberproducts = rnd.Next(0, 10);
            for (int i=0; i<=numberproducts; i++)
            {
                string nameproduct = getRandomNameProduct();
                int quantityproduct = rnd.Next(0, 10);
                if (randomclientwishes.ContainsKey(nameproduct)) 
                {
                    continue;
                }
                else
                {
                    randomclientwishes.Add(nameproduct, quantityproduct);
                }
            }
            return randomclientwishes;
        }

        public Client AddRandomClient()
        {
            string name = getRandomName();
            string surname = getRandomLastName();
            int age = getRandomAge();
            string sex = getRandomSex();
            int rut = getRandomRut();
            string birthdate = getBirthDate();
            string nationality = getRandomNationality();
            Dictionary<string, int> clientwishes = getRandomClientwishes();
            Client newclient = new Client(name, surname, age, sex, rut, birthdate, nationality, clientwishes);
            return newclient;
        }

        public Employee AddRandomEmployee()
        {
            string name = getRandomName();
            string surname = getRandomLastName();
            int age = getRandomAge();
            string sex = getRandomSex();
            int rut = getRandomRut();
            string birthdate = getBirthDate();
            string nationality = getRandomNationality();
            string position = getRandomPosition();
            int salary = getRandomSalary(position);
            int entry = getRandomEntry(position);
            int exit = getRandomExit(position);
            Employee newemployee = new Employee(name, surname, age, sex, rut, birthdate, nationality, position, salary, entry, exit);
            return newemployee;
        }

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

        public void ProductsInformation()
        {
            foreach (Product i in products)
            {
                Console.WriteLine(i.ProductInformation() + "\n");
            }
        }
        public void EmployeesInformation()
        {
            foreach (Employee i in employees)
            {
                Console.WriteLine(i.EmployeeInformation() + "\n");
            }
        }
        public void ClientsInformation()
        {
            foreach (Client i in clients)
            {
                Console.WriteLine(i.ClientInformation()+"\n");
            }
        }

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

        public void ChangeEmployee(int rut, string answer)
        {
            int contador = 0;
            foreach (Employee i in employees)
            {
                if (i.Rut == rut)
                {
                    if (answer == "1")
                    {
                        Console.WriteLine("Ingrese nuevo cargo");
                        string newposition = Console.ReadLine();
                        i.Position = newposition;
                    }
                    else if (answer == "2")
                    {
                        bool turnon;
                        string Salary;
                        int salary;
                        do
                        {
                            Console.WriteLine("Ingrese nuevo sueldo del empleado: ");
                            Salary = Console.ReadLine();
                            turnon = int.TryParse(Salary, out salary);
                        }
                        while (!turnon);
                        salary = Convert.ToInt32(Salary);
                        i.Salary = salary;
                    }
                    else if (answer == "3")
                    {
                        bool turnon;
                        string Entry;
                        int newentry;
                        do
                        {
                            Console.WriteLine("Ingrese nuevo horario de entrada: ");
                            Entry = Console.ReadLine();
                            turnon = int.TryParse(Entry, out newentry);
                        }
                        while (!turnon);
                        newentry = Convert.ToInt32(Entry);
                        i.Entry = newentry;

                        bool turnon2;
                        string Exit;
                        int newexit;
                        do
                        {
                            Console.WriteLine("Ingrese nuevo horario de salida: ");
                            Exit = Console.ReadLine();
                            turnon2 = int.TryParse(Exit, out newexit);
                        }
                        while (!turnon2);
                        newexit = Convert.ToInt32(Exit);
                        i.Exit = newexit;
                    }
                    Console.WriteLine("EMPLEADO MODIFICADO: " + i.EmployeeInformation());
                }
                else
                {
                    contador += 1;
                }
            }
            if (contador == employees.Count)
            {
                Console.WriteLine("El empleado no existe");
            }
        }
        static Random rnd = new Random();
        public string RandomSeller()
        {
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            List<string> possibleSeller = new List<string>();
            foreach (Employee e in employees)
            {
                if ((e.Position == "Cajero" || e.Position == "cajero") && e.Entry <= hour && e.Exit > hour)
                {
                    possibleSeller.Add(e.EmployeeInformation());
                }
                else
                {
                    continue;
                }
            }
            int index = rnd.Next(possibleSeller.Count);
            if (possibleSeller.Count == 0) return "No hay cajeros disponibles";
            else return possibleSeller[index];

        }


        public string Buy()
        {
            if (RandomSeller() == "No hay cajeros disponibles")
            {
                return RandomSeller();
            }
            else
            {
                string ticket = "";
                foreach (Client a in clients)
                {
                    string shoppingcart = "";
                    string seller = RandomSeller();
                    int totalprice = 0;
                    foreach (KeyValuePair<string, int> i in a.Clientwishes)
                    {
                        int quantity = i.Value;
                        int price;
                        string nameproduct = i.Key.ToLower();
                        int counter = 0;
                        foreach (Product p in products)
                        {
                            if (quantity == 0)
                            {
                                continue;
                            }
                            else
                            {
                                if (p.Nameproduct.ToLower() == nameproduct && p.Stock >= quantity)
                                {
                                    price = quantity * p.Price;
                                    totalprice += price;
                                    shoppingcart += "producto: " + i.Key + ", marca: " + p.Brand + ", cantidad: " + quantity + ", precio unitario: " + p.Price + ", precio total: " + price + "\n";
                                    p.Stock -= quantity;
                                    quantity = 0;
                                }
                                else if (p.Nameproduct.ToLower() == nameproduct && p.Stock < quantity && p.Stock > 0)
                                {
                                    price = p.Stock * p.Price;
                                    totalprice += price;
                                    shoppingcart += "Producto: " + i.Key + ", marca: " + p.Brand + ", cantidad: " + p.Stock + ", precio unitario: $" + p.Price + ", precio total: $" + price + "\n";
                                    quantity -= p.Stock;
                                    p.Stock -= p.Stock;
                                }
                                else
                                {
                                    counter += 1;
                                }

                            }

                        }
                        if (counter == products.Count)
                        {
                            shoppingcart += "Producto: " + i.Key + " no está en tienda\n";
                        }
                        else if (quantity != 0)
                        {
                            shoppingcart += "No se pudieron agregar " + quantity + " " + i.Key + "\n";
                        }
                    }
                    DateTime now = DateTime.Now;
                    ticket += "INFORMACIÓN CLIENTE: " + a.ClientInformation() + "\nCOMPRAS: \n" + shoppingcart + "VENDEDOR: " + seller + "\nPRECIO TOTAL: $" + totalprice + "\nFECHA Y HORA: " + now + "\n";
                    ticket += "\n";

                }
                return ticket;
            }
        }


    }
}
