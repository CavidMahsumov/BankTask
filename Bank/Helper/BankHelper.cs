using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    static class BankHelper
    {
        
        public static void PrintWorkers(Worker[] workers)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("++++++Workers Info++++++");
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"{i+1} Name : {workers[i].Name}   Surname : {workers[i].Surname}   Age  : {workers[i].Age}");
            }
            Console.ResetColor();
        }
        public static void PrintManagers(Manager[] managers)
        {
            if (managers != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("++++++Managers Info++++++");
                for (int i = 0; i < managers.Length; i++)
                {
                    Console.WriteLine($"{i+1}  Name : {managers[i].Name}  Surname : {managers[i].Surname}  Age : {managers[i].Age}");
                }
                Console.ResetColor();
            }
        }
        public static void PrintCeo(CEO ceo)
        {
            if (ceo != null)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("+++++++Ceo Info++++++");
                Console.WriteLine($" Name  : {ceo.Name}  Surname : {ceo.Surname}   Age : {ceo.Age}");
            }
            Console.ResetColor();
        }
        public static void ShowBankInfo(Bank bank)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("++++++Bank Info+++++++");
            Console.WriteLine(bank.ToString());
            Console.ResetColor();
            
        }
        public static void ShowBankClient(Client[] clients)
        {
            if (clients != null)
            {
                for (int i = 0; i < clients.Length; i++)
                {
                    Console.WriteLine($"{i}  Name : {clients[i].Name}  Surname : {clients[i].Surname}  Age : {clients[i].Age} ");
                    Console.WriteLine($"Work Adress : {clients[i].Work_Adress}   Live Adress : {clients[i].Live_Adress} Salary : {clients[i].Salary}");
                }
            }
        }
        
        
        
    }
}
