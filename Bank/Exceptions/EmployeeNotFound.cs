using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Exceptions
{
    class EmployeeNotFound:ApplicationException
    {
        public EmployeeNotFound(string message):base(message)
        {

        }
    }
}
