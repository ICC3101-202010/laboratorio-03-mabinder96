using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Employee : Person, IWork,ISell
    {
        private string position; //acá puedo elegir si es supervisor, cajero, jefe, asistente, empaquetador, reponedor y los cargos de los clientes etc.
        private int salary;
        private string workinghours;

        public Employee()
        {
            this.name = getRandomName();
            this.surname = getRandomLastName();
            this.age = getRandomAge();
            this.sex = getRandomSex();
            this.rut = getRandomRut();
            this.birthdate = getBirthDate();
            this.nationality = getRandomNationality();
            this.position = getRandomPosition();
            this.salary = getRandomSalary();
            this.workinghours = getRandomWorkingHours();
        }


        public override void Eat()
        {
            Console.WriteLine("Soy" + name + "y estoy comiendo");
        }
        public override void Touch()
        {
            Console.WriteLine("Soy" + name + "y estoy tocando");
        }
        public override void Communicate()
        {
            Console.WriteLine("Soy" + name + "y me estoy comunicando");
        }

        public Employee Work(Employee position)
        {
            Console.WriteLine("Soy" + name + "y trabajo en"+position);
            return position;
        }
        public int Salary(int salary)
        {
            return salary;
        }
        public int Workinghours(int workinghours)
        {
            return workinghours;
        }

        public int Sell(Product nameproduct)
        {
            int total = nameproduct.Stockinshowcase + nameproduct.Stockincellar;
            if (nameproduct.Stockinshowcase == 0 && nameproduct.Stockincellar==0)
            {
                Console.WriteLine("No quedan productos en la vitrina ni en la bodega");
            }
            else if (nameproduct.Stockinshowcase == 0 && nameproduct.Stockincellar!= 0)
            {
                Console.WriteLine("No quedan productos en la vitrina, pero quedan "+ nameproduct.Stockincellar +" en la bodega");
            }
            else if (nameproduct.Stockinshowcase != 0 && nameproduct.Stockincellar == 0)
            {

                Console.WriteLine("¡Apúrate, quedan " + nameproduct.Stockinshowcase + " en la vitrina y no quedna en la bodega");
            }
            else
            {
                Console.WriteLine("Quedan " +total + " en el supermercado");
            }
            return total;
        }
        public string Work(string position)
        {
            return position;
        }

        public Random randomGenerator;
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
            return possibleFirstNames[randomGenerator.Next(possibleFirstNames.Length)];
        }
        public string getRandomLastName()
        {
            string[] possibleLastNames = new string[]
            {
                "Abstaburagua", "Benavides", "Correa", "Dominguez", "Echeverría", "Fontanet", "González", "Herrera", "Izquierdo", "Jimenez", "Küpfer", "López", "Medina",
                "Nadal", "Opazo", "Pérez", "Quiroga", "Rodríguez", "Silva", "Turner", "Urrejola", "Valdivia", "Wolff", "Yañez", "Zirpel"
            };
            return possibleLastNames[randomGenerator.Next(possibleLastNames.Length)];
        }
        public int getRandomAge()
        {
            return randomGenerator.Next(18, 95);
        }

        public string getRandomRut()
        {
            string rut = "";
            for (int i = 0; i <= 9; i++)
            {
                rut += randomGenerator.Next(0, 9);
            }
            return rut;
        }
        public string getRandomSex()
        {
            string[] possibleSex = new string[]
            {
                "Femenino", "Masculino"
            };
            return possibleSex[randomGenerator.Next(possibleSex.Length)];
        }
        public string getRandomNationality()
        {
            string[] possibleNationality = new string[]
            {
                "Chilena", "Venezolana", "Peruana", "Argentina", "Alemana", "Italiana", "Española", "China", "Boliviana", "Japonesa", "Francesa","Suiza"
            };
            return possibleNationality[randomGenerator.Next(possibleNationality.Length)];
        }


        public string getBirthDate()
        {
            string day = "";
            for (int i = 0; i <= 2; i++)
            {
                day += randomGenerator.Next(0, 30);
            }
            string[] possibleMonth = new string[]
           {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre","Diciembre"
           };

            string year = "";
            for (int i = 0; i <= 4; i++)
            {
                year += randomGenerator.Next(1990, 2000);
            }

            string birthdate = "";
            birthdate += day;
            birthdate += "/";
            birthdate += possibleMonth[randomGenerator.Next(possibleMonth.Length)];
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
            return possiblePosition[randomGenerator.Next(possiblePosition.Length)];
        }

        public int getRandomSalary()
        {
            if (position == "Gerente")
            {
                return randomGenerator.Next(2000000, 2500000);
            }
            else if (position == "Cajero")
            {
                return randomGenerator.Next(800000, 1200000);
            }
            else if (position == "Auxiliar")
            {
                return randomGenerator.Next(600000, 800000);
            }
            else if (position == "Reponedor")
            {
                return randomGenerator.Next(800000, 1200000);
            }
            else if (position == "Empaquetador")
            {
                return randomGenerator.Next(500000, 600000);
            }
            else if (position == "Limpiador")
            {
                return randomGenerator.Next(400000, 600000);
            }
            else
            {
                return randomGenerator.Next(1000000, 2000000);
            }
        }

        public string getRandomWorkingHours()
        {
            if (position == "Gerente")
            {
                return "9:00-20.00";
            }
            else if (position == "Cajero" || position == "Reponedor" || position=="Auxiliar")
            {
                string[] possibleWorkingHours = new string[]
            {
                "8:00-16:00", "15:00-23:00"
            };
                return possibleWorkingHours[randomGenerator.Next(possibleWorkingHours.Length)];
            }
            
            else if (position == "Empaquetador")
            {
                return "10:00-21:00";
            }
            else if (position == "Limpiador")
            {
                string[] possibleWorkingHours = new string[]
            {
                "8:00-11:00", "20:00-23:00", "13.00-16:00"
            };
                return possibleWorkingHours[randomGenerator.Next(possibleWorkingHours.Length)];
            }
            else
            {
                return "9:00-20.00";
            }
        }

    }
}
