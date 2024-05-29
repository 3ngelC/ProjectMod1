using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    public interface ICharacter
    {
        string Name { get; }
        string Description { get; }
        Item[] Items { get; }

        
    }
}
