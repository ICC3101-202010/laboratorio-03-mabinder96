using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Supermarket //Creo la clase supermercado
    {
        public Supermarket() //Creo el constructor vacío
        {

        }
        List<Product> products = new List<Product>(); //Creo lista de productos que tiene el supermercado
       
        //Creo método para agregar productos
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        //Creo método para ver productos  que me entrega el producto con su información 
        public void ShowProducts(string product)
        {
            List<Product> answer = new List<Product>();
            foreach (Product a in products)
            {
                if (a.Nameproduct == product)
                {
                    answer.Add(a);
                }
            }
            foreach(Product b in products)
            {
                Console.WriteLine(b.ProductInformation());
            }
        }

        public void Buy(string product, string brand, int quantity)
        {
            List<Product> items = new List<Product>();
            for (int i = 0; i < products.Count; ++i)
            {
                if (products.Count == 0)
                {
                    Console.WriteLine("Este supermecado no tiene productos");
                }
                else if (products[i].Nameproduct==product && products[i].Brand == brand)
                {
                    if (products[i].Stockinshowcase >= quantity)
                    {
                        Console.WriteLine("Se ha realizado tu compra.");
                        products[i].Stockinshowcase -= quantity;
                    }
                    if (products[i].Stockinshowcase < quantity && products[i].Stockincellar >= quantity)
                    {
                        Console.WriteLine("No quedan productos en la vitrina, pero sí en la bodega. Se ha realizado su compra.");
                        products[i].Stockincellar -= quantity;
                    }
                    else
                    {
                        Console.WriteLine("No se ha podido realizar su compra, producto agotado");
                    }
                }

            }

        }

    }
