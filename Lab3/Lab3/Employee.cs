using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Employee : Person
    {
        //Creo los atributos que son propios del empleado
        private string position; //Acá puedo elegir si es supervisor, cajero, jefe, asistente, empaquetador, reponedor y los cargos de los clientes etc.
        private int salary;
        private int entry;
        private int exit;
        
        //Creo el constructor del empleado donde incluyo los atributos heredados de la clase persona
        public Employee(string name, string surname, int age, string sex, int rut, string birthdate, string nationality, string position, int salary,  int entry, int exit)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.sex = sex;
            this.rut = rut;
            this.birthdate = birthdate;
            this.nationality = nationality;
            this.position = position;
            this.salary = salary;
            this.entry = entry;
            this.exit = exit;
        }

        //Encapsulo los atributos que voy a necesitar 
        public string Position { get => position; set => position = value; }
        public int Salary { get => salary; set => salary = value; }
        public int Entry { get => entry; set => entry = value; }
        public int Exit { get => exit; set => exit = value; }
        public string Name { get => name; set => name = value; }
        public int Rut { get => rut; set => rut = value; }

        //Creo método que me devuelve la información del trabajador
        public string EmployeeInformation()
        {
            return "Nombre: " + name + ", apellido: " + surname + ", edad: " + age + ", rut: " + rut + ", género: " + sex + ", nacionalidad: " + nationality + ", fecha de nacimiento: " + birthdate + ", sueldo: " + salary + ", horario: " + entry + ":00-" + exit + ":00"+ ", cargo: " + position;
        }
    }
}