using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Gato : Mamifero
    {
        public Gato()
        {
            base.comer();
            Console.WriteLine(" - > Gato");
            this.comer();
        }

        public override void comer()
        {
            Console.WriteLine("Os gatos são carnívoros");
        }
    }
}
