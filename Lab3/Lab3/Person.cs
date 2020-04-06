using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Person
    {
        //Creo los atributos que van a tener todas las personas
        protected string name;
        protected string surname;
        protected int age;
        protected string sex;
        protected int rut; //Si termina en k, se reemplaza por 0
        protected string birthdate;
        protected string nationality;

    }
}
