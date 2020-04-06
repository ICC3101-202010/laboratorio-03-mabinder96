using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Client : Person
    {

        private Dictionary<string, int> clientwishes;
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

        public Dictionary<string, int> Clientwishes { get => clientwishes; set => clientwishes = value; }

        public string ClientInformation()
        {
            return "Nombre: " + name + ", apellido: " + surname + ", edad: " + age + ", rut: " + rut + ", género: " + sex + ", nacionalidad: " + nationality + ", fecha de nacimiento: " + birthdate;
        }

    }
}