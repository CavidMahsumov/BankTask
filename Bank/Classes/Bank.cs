using Bank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    class Bank
    {
        public string Name { get; set; }
        public double Budget { get; set; }
        public double Profit { get; set; }
        public CEO Ceo { get; set; }
        public Worker[] workers { get; set; }
        public Manager[] Managers { get; set; }
        public Client[] clients { get; set; }
        public Credit[] credits { get; set; }
        public int workercount { get; set; }
        public int ManagerCount { get; set; }
        public int ClientCount { get; set; }
        public int CreditCount { get; set; }
        public override string ToString()
        {
            return $"Name : {Name}  Budget : {Budget}  Profit {Profit}  WorkerCount : {workercount}  ClientCount : {ClientCount}";
        }
        public void showClientCredit(string name)
        {
            try
            {

                foreach (var item in credits)
                {
                    if (item.Client.Name == name)
                    {
                        item.Show();
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message : {ex}");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Client Not Found");
            System.Threading.Thread.Sleep(1000);
            Console.ResetColor();
            throw new NotClientException("Not Client Exception");
        }
        public void GiveCredit(Credit credit)
        {
            try
            {
                if (Budget >= credit.amount)
                {
                    Budget -= credit.amount;
                    Profit += credit.amount % 12;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Money is very High");
                    System.Threading.Thread.Sleep(1000);
                    Console.ResetColor();
                    throw new NotCreditException("Not Credit Exception");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message : {ex}");
            }
           
        }
        public void PayCredit(string name, double money)
        {
            foreach (var item in credits)
            {
                if (name == item.Client.Name)
                {
                    item.Payment += money;
                    item.amount -= money;
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("User Is Not Found");
            System.Threading.Thread.Sleep(2000);
            throw new NotClientException("Client is Not Found");

        }
        public double ExchangeMoney(string Type,double money)
        {
            if (Budget >= money)
            {
                double sum = 0;
                if (Type == "Dollar")
                {
                    Budget += (MoneyValue.Dollar * money) % 10;
                    sum = MoneyValue.Dollar * money;
                    Console.WriteLine($"AZN : {sum}");

                    return sum;
                }
                else if (Type == "Euro")
                {
                    Budget += (MoneyValue.Euro * money) % 10;
                    sum = MoneyValue.Euro * money;
                    Console.WriteLine($"AZN : {sum}");

                    return sum;
                }
                else if (Type == "Tl")
                {
                    Budget += (MoneyValue.Tl * money) % 10;
                    sum = MoneyValue.Tl * money;
                    Console.WriteLine($"AZN : {sum}");
                    return sum;
                }
                else
                {
                    throw new ExchangeException("Wrong Selection");
                }
            }
            else
            {
                throw new NotEnoughMoneyException("The Bank does not have succifent funds");
            }

            
            return 0;
        }
        public void ShowAllCredit()
        {
            foreach (var item in credits)
            {
                item.Show();
            }
        }
        public void AddWorker(Worker worker)
        {
            Worker[] newWorkers = new Worker[++workercount];
            if (workers != null)
            {
                this.workers.CopyTo(newWorkers, 0);
            }
            newWorkers[newWorkers.Length - 1] = worker;
            this.workers = newWorkers;
        }

        public void AddManager(Manager manager)
        {
            Manager[] newManager = new Manager[++ManagerCount];
            if (Managers != null)
            {
                this.Managers.CopyTo(newManager, 0);
            }
            newManager[newManager.Length - 1] = manager;
            this.Managers = newManager;
        }
        public void AddClient(Client client)
        {
            Client[] newclients = new Client[++ClientCount];
            if (this.clients != null)
            {
                this.clients.CopyTo(newclients, 0);
            }
            newclients[newclients.Length - 1] = client;
            this.clients = newclients;
        }
        public void AddCredit(Credit credit)
        {
            Credit[] newcredits = new Credit[++CreditCount];
            if (credits != null)
            {
                credits.CopyTo(newcredits, 0);
            }
            newcredits[newcredits.Length - 1] = credit;
            this.credits = newcredits;
        }


    }
}
