using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Exceptions
{
    class NotEnoughMoneyException:ApplicationException
    {
        public NotEnoughMoneyException(string message):base(message)
        {

        }
    }
}
