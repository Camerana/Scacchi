using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scacchi.Pedine
{
    abstract class Pedina
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public string Simbolo { get; set; }
        public Pedina(Random r)
        {
            this.XPosition = r.Next(0, 20);
            this.YPosition = r.Next(0, 10);
        }
    }
}
