using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Exceptions
{
    class ExchangeException:ApplicationException
    {
        public ExchangeException(string message):base(message)
        {

        }
    }
}
