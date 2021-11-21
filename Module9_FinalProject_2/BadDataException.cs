using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9_FinalProject_2
{
    public class BadDataException : Exception
    {
        public BadDataException(string message) : base(message)
        {

        }
    }
}
