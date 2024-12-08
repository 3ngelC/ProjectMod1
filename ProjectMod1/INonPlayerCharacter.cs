using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    
    public interface INonPlayerCharacter : ICharacter
    {
        
        void IntroduceNPC(int level);

        void AddItem(int level);
        
    }
}
