using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    // Start and Stop machine
    public abstract class Machine
    {
        public abstract string Start();
        public abstract string Stop();
    }
}
