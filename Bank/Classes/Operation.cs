using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Operation : Base
    {
        public string Proccess_Name { get; set; }
        public DateTime DateTime { get; set; }
        public Operation(Guid guid, string ProccessName, DateTime dateTime) : base(guid)
        {
            Proccess_Name = ProccessName;
            DateTime = dateTime;

        }
    }
}
