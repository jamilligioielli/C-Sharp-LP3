using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Anfibio : Animal
    {
        public Anfibio()
        {
            base.comer();
            Console.WriteLine(" - > Anfíbio");
        }

        public override void comer()
        {
            Console.WriteLine("Anfíbios adultos costumam ser carnívoros");
        }
    }
}
