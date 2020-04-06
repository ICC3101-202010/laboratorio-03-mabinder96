using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Product
    {
        private string nameproduct;
        private int price;
        private string brand;
        private int stock;
        private string type;


        public Product(string nameproduct, int price, string brand, int stock, string type)
        {
            this.nameproduct = nameproduct;
            this.price = price;
            this.brand = brand;
            this.stock = stock;
            this.type = type;
        }

        public string Nameproduct { get => nameproduct; set => nameproduct = value; }
        public int Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Type { get => type; set => type = value; }
        public string ProductInformation()
        {
            return "Nombre: " + nameproduct + ", precio: " + price + ", marca: " + brand + ", stock: " + stock  + ", tipo: " + type;
        }
    }
}