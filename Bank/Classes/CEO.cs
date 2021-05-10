using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class CEO : Base, IOrganizer
    {
        public CEO(Guid guid, string name, string surname, int age, double salary, string position) :
            base(guid, name, surname, age, salary, position)
        {

        }

        public void Organizer()
        {
            Console.WriteLine("I am Organizer");
        }
        public void Control()
        {
            Console.WriteLine("I am Control All");
        }
        public void MakeMeeting(Worker[] workers)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Meeting is started");
            Console.ResetColor();
            Console.Write("ParticPant : ");
            BankHelper.PrintWorkers(workers);
            for (int i = 10; i >0; i--)
            {
                Console.WriteLine($"Meeting End : {i}");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("Meeting is Ended");

        }
        public void DecreasePercentage(double percent)
        {
            Credit.Percent -= percent;
            

        }

    }
}
