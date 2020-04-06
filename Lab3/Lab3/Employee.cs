﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Employee : Person
    {
        private string position; //acá puedo elegir si es supervisor, cajero, jefe, asistente, empaquetador, reponedor y los cargos de los clientes etc.
        private int salary;
        private string workinghours;

        public Employee(string name, string surname, int age, string sex, int rut, string birthdate, string nationality, string position, int salary, string workinghours)
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
            this.workinghours = workinghours;
        }

        public string Position { get => position; set => position = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Workinghours { get => workinghours; set => workinghours = value; }

        public string Name { get => name; set => name = value; }

        public string ChangePosition(string position)
        {
            return position;
        }
        public int ChangeSalary(int salary)
        {
            return salary;
        }
        public int ChangeWorkinghours(int workinghours)
        {
            return workinghours;
        }
        public string EmployeeInformation()
        {
            return "nombre: " + name + ", apellido: " + surname + ", edad: " + age + ", rut: " + rut + ", género: " + sex + ", nacionalidad: " + nationality + ", fecha de nacimiento: " + birthdate + ", sueldo: " + salary + ", horario: " + workinghours + ", cargo: " + position;
        }

    }
}