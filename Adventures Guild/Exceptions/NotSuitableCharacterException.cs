using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Exceptions
{
    public class NoSuitableCharacterException : Exception
    {
        public NoSuitableCharacterException(string message)
        : base(message)
        {
        }
    }
}
