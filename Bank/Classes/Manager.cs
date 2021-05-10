using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Manager : Base, IOrganizer
    {
        public Manager(Guid guid, string name, string surname, int age, double salary, string position) :
            base(guid, name, surname, age, salary, position)
        {

        }

        public void Organizer()
        {
            Console.WriteLine("I am Organizer");
        }
        public double CalculateSalaries(Worker[]workers)
        {
            double totalSalaries = 0;
            if (workers != null)
            {
                foreach (var item in workers)
                {
                    totalSalaries += item.Salary;
                }
            }
            return totalSalaries;
        }
    }
}
