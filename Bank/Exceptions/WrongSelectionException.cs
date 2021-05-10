using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Exceptions
{
    class WrongSelectionException:ApplicationException
    {
        public WrongSelectionException(string message):base(message)
        {

        }
    }
}
