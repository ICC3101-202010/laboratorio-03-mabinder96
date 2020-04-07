using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Client : Person
    {
        //Creo el atributo clientwishes que es una diccionario propio del cliente, donde se va a almacenar las cosas que quiere comprar
        private Dictionary<string, int> clientwishes;

        //Creo el constructor del cliente donde incluyo los atributos heredados de la clase persona
        public Client(string name, string surname, int age, string sex, int rut, string birthdate, string nationality, Dictionary<string, int> clientwishes)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.sex = sex;
            this.rut = rut;
            this.birthdate = birthdate;
            this.nationality = nationality;
            this.clientwishes = clientwishes;
        }

        //Encapsulo los atributos que voy a necesitar
        public Dictionary<string, int> Clientwishes { get => clientwishes; set => clientwishes = value; }
        public int Rut { get => rut; set => rut = value; }
        public string Name { get => name; set => name = value; }

        //Creo método que me devuelve la información del trabajador
        public string ClientInformation()
        {
            return "Nombre: " + name + ", apellido: " + surname + ", edad: " + age + ", rut: " + rut + ", género: " + sex + ", nacionalidad: " + nationality + ", fecha de nacimiento: " + birthdate;
        }
    }
}