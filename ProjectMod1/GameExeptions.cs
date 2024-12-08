using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    internal class GameExeptions
    {
        public class NoItemsExeption : Exception
        {
            public NoItemsExeption() : base() { }
            public NoItemsExeption(string message) : base(message)
            {
                throw new NoItemsExeption("The player has not items");
            }
            public NoItemsExeption(string message, Exception innerException) : base(message, innerException) { }
        }
    }
}
