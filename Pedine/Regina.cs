using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scacchi.Pedine
{
    class Regina : Pedina
    {
        public Regina(Random r) : base(r)
        {
            this.Simbolo = "Q";
        }
    }
}
