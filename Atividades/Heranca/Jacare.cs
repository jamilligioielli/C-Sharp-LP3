using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Jacare : Reptil
    {
        public Jacare()
        {
            base.comer();
            Console.WriteLine(" - > Jacaré");
            this.comer();
        }

        public override void comer()
        {
            Console.WriteLine("Os jacarés são carnívoros");
        }
    }
}
