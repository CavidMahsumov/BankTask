using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Worker : Base
    {
        public Operation[] Operation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int OperationCount { get; set; }
        public override string ToString()
        {
            return $"Start Time : {StartTime}    EndTime : {EndTime}";
        }

        public Worker(Guid guid, string name, string surname, int age, double salary, string position, DateTime starttime, DateTime endtime) :
          base(guid, name, surname, age, salary, position)
        {
            this.StartTime = starttime;
            this.EndTime = endtime;
        }

        public void AddOperations(Operation operation)
        {
            Operation[] newOperation = new Operation[++OperationCount];
            if (Operation != null)
            {
                this.Operation.CopyTo(newOperation, 0);
            }
            newOperation[newOperation.Length-1] = operation;
            this.Operation = newOperation;
        }
        public void ShowOperation()
        {
            if (this.Operation != null)
            {
                foreach (var item in Operation)
                {
                    item.Show();
                }
            }
        }


    }
}
