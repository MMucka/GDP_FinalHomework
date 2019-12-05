using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class AudioInterface
    {
        public virtual void PlaySound() { } // Play sound using console audio api...
        public virtual void StopSound() { } // Stop sound using console audio api...
    }
}
