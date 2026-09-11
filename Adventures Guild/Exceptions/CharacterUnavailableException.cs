using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Exceptions
{
    public class CharacterUnavailableException : Exception
    {
        public CharacterUnavailableException(string message)
        : base(message)
        {
        }
    }
}
