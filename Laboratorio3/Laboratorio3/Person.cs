using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public abstract class Person
    {
        protected string name;
        protected string surname;
        protected int age;
        protected string sex;
        protected string rut; //Si termina en k, se reemplaza por 0
        protected string birthdate;
        protected string nationality;
        public abstract void Eat();
        public abstract void Communicate();
        public abstract void Touch();
    }
}
