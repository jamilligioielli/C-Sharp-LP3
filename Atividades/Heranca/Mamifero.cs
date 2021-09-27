using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Mamifero : Animal
    {
        public Mamifero()
        {
            base.comer();
            Console.WriteLine(" - > Mamifero");
        }
        public override void comer()
        {
            Console.WriteLine("Mamiferos são herbívoros, carnívoros ou onívoros");
        }
    }
}
