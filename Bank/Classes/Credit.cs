using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Credit : Base
    {
        public Client Client { get; set; }
        public double amount { get; set; }//kredit
        public static double Percent { get; set; } = 12;//faiz
        public int Months { get; set; }
        public double Payment { get; set; }//odenis
        public double PaymnetMonth { get; set; }
        public Credit(Guid guid, Client client, int amount, double percent, int months, double Payment) : base(guid)
        {
            Client = client;
            this.amount = amount;
            Percent = percent;
            Months = months;
            this.Payment = Payment;
        }
        public void CalculatePercent()
        {
            double payment = (amount * Percent) + amount;
            double paymentmonth = payment / Months;
            Payment = payment;
            this.PaymnetMonth = paymentmonth;
            Console.WriteLine($"Your Payment : {payment}");
            Console.WriteLine($"Your Paymet Month : {paymentmonth}");
            //percent *amount(Parametr)
        }

        public new void Show()
        {
            Client.Show();
            Console.WriteLine($"Amount : {amount}");
            Console.WriteLine($"Percent : {Percent}");
            Console.WriteLine($"Months : {Months}");
            Console.WriteLine($"Paymnet : {Payment}");
            Console.WriteLine($"Paymnet Months : {PaymnetMonth}");
        }
    }
}
