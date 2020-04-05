using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Product
    {
        private string nameproduct;
        private int price;
        private string brand;
        private int stockinshowcase;
        private int stockincellar;
        private string type;


        public Product(string nameproduct, int price, string brand, int stockinshowcase, int stockincellar, string type)
        {
            this.nameproduct = nameproduct;
            this.price = price;
            this.brand = brand;
            this.stockinshowcase = stockinshowcase;
            this.stockincellar = stockincellar;
            this.type = type;
        }

        public string Nameproduct { get => nameproduct; set => nameproduct = value; }
        public int Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Stockinshowcase { get => stockinshowcase; set => stockinshowcase = value; }
        public int Stockincellar { get => stockincellar; set => stockincellar = value; }
        public string Type { get => type; set => type = value; }
        public Random randomGenerator;

        public string getRandomLastName()
        {
            string[] possibleLastNames = new string[]
            {
                "Manzanas", "Zanahorias", "Duraznos", "Naranjas", "Ramitas", "Papas fritas", "Cocacola", "Sprite", "Fanta", "Jugo de naranja", "Jugo de Frutilla", "Jugo de mango", "Pepsi", "Canada Dry", "Crush","Galletas", "Cheetos", "Doritos", "Cigarros", "Energizante",
                "Pisco", "Vodka", "Barrita de cereal", "Dulces", "Pan", "Mermelada"
            };
            return possibleLastNames[randomGenerator.Next(possibleLastNames.Length)];
        }

        public string getType()
        {
            if (nameproduct == "Manzanas" || nameproduct == "Naranjas" || nameproduct == "Duraznos" || nameproduct == "Zanahorias")
            {
                return "Frutas y verduras";
            }
            else if (nameproduct == "Ramitas" || nameproduct == "Papas fritas" || nameproduct == "Galletas" || nameproduct == "Cheetos" || nameproduct == "Doritos"||nameproduct=="Barritas de cereal" || nameproduct=="Dulces")
            {
                return "Coaciones";
            }
            else if (nameproduct == "Cocacola" || nameproduct == "Fanta"||nameproduct == "Sprite" || nameproduct == "Jugo de naranja" || nameproduct == "Jugo de Frutilla" || nameproduct == "Jugo de mango" || nameproduct == "Pepsi" || nameproduct == "Canada Dry"||nameproduct=="Crush")
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
            else if (nameproduct == "Cigarros" )
            {
                return "Vicios";
            }
            else
            {
                return "Otros";
            }

        }


        public int getRandomPrice()
        {
            if (type== "Frutas y verduras")
            {
                return randomGenerator.Next(200, 500);
            }
            else if (type == "Colaciones")
            {
                return randomGenerator.Next(500, 1500);
            }
            else if (type == "Bebestibles")
            {
                return randomGenerator.Next(1000, 1500);
            }
            else if (type == "Energizantes")
            {
                return randomGenerator.Next(1000, 2000);
            }
            else if (type == "Alcohol")
            {
                return randomGenerator.Next(5000, 10000);
            }
            else if (type == "Vicios")
            {
                return randomGenerator.Next(2000, 3000);
            }
            else 
            {
                return randomGenerator.Next(1500, 3000);
            }
        }

        public string getRandomBrand()
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
                return possibleBrands[randomGenerator.Next(possibleBrands.Length)];
            }
            else if (type == "Bebestibles")
            {
                string[] possibleBrands = new string[]
            {
                "CCU", "Watts", "Livean", "PepsiCo"
            };
                return possibleBrands[randomGenerator.Next(possibleBrands.Length)];
            }
            else if (type == "Energizantes")
            {
                string[] possibleBrands = new string[]
            {
                "RedBull", "Monster"
            };
                return possibleBrands[randomGenerator.Next(possibleBrands.Length)];
            }
            else if (type == "Alcohol")
            {
                string[] possibleBrands = new string[]
            {
                "Absolut", "Alto del Carmen", "Smirnoff", "Capel"
            };
                return possibleBrands[randomGenerator.Next(possibleBrands.Length)];
            }
            else if (type == "Vicios")
            {
                string[] possibleBrands = new string[]
            {
                "Palmal Click", "Lucky Strike", "Kent"
            };
                return possibleBrands[randomGenerator.Next(possibleBrands.Length)];
            }
            else
            {
                return "Elaboración propia";
            }
        }

        public int getRandomStock()
        {
            return randomGenerator.Next(0, 10);
        }
        

        public string ProductInformation()
        {
            return "nombre: "+ nameproduct + ", precio: "+price+", marca: "+ brand + ", stock en vitrina: "+ stockinshowcase + ", stock en bodega: "+ stockincellar +", tipo: "+ type;
        }
    }
}
