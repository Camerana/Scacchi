using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scacchi.Pedine
{
    class Re : Pedina
    {
        public Re(Random r) : base(r)
        {
            this.Simbolo = "R";
        }
    }
}
