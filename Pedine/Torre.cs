using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scacchi.Pedine
{
    class Torre : Pedina
    {
        public Torre(Random r) : base(r)
        {
            this.Simbolo = "T";
        }
    }
}
