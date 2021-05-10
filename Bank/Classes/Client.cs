using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Client : Base
    {
        public string UnicId { get; set; }
        public string Live_Adress { get; set; }

        public string Work_Adress { get; set; }

        public Client(Guid guid, string name, string surname, int age, int salary, string Liveadress, string workadress,string id)
            : base(guid, name, surname, age, salary)
        {
            Live_Adress = Liveadress;
            Work_Adress = workadress;
            UnicId = id;
        }
        
        public new void Show()
        {
            Console.WriteLine("++++++++++Client Info++++++++");
            Console.WriteLine($"Unic Id : {UnicId}");
            Console.WriteLine($" Live Adress :{Live_Adress}");
            Console.WriteLine($"Work Adress : {Work_Adress}");
            base.Show();
        }
    }
}
