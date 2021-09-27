using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Cachorro : Mamifero
    {
        public Cachorro()
        {
            base.comer();
            Console.WriteLine(" - > Cachorro");
            comer();
        }

        public override void comer()
        {
            Console.WriteLine("Os cachorros são carnívoros");
        }
    }
}
