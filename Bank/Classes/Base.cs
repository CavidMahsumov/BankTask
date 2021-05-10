using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class Base
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
        public Base(Guid guid, string name, string surname, int age, double salary, string position)
        {
            this.Guid = guid;
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            Position = position;
        }
        public Base(Guid guid, string name, string surname, int age, double salary)
        {
            this.Guid = guid;
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }
        public Base(Guid guid)
        {
            this.Guid = guid;
        }

        public void Show()
        {
            Console.WriteLine($"Guid : {Guid}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Position : {Position}");
            Console.WriteLine($"Salary : {Salary}");
        }


    }
}
