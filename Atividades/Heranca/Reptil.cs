using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Reptil : Animal
    {
        public Reptil()
        {
            base.comer();
            Console.WriteLine(" - > Reptil");
        }

        public override void comer()
        {
            Console.WriteLine("Reptéis são carnívoros, mas também podem ser onívoros");
        }
    }
}
