using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scacchi.Pedine
{
    class Alfiere : Pedina
    {
        public Alfiere(Random r) : base(r)
        {
            this.Simbolo = "A";
        }
    }
}
