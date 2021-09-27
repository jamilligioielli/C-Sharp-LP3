using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Sapo : Anfibio
    {
        public Sapo()
        {
            base.comer();
            Console.WriteLine(" - > Sapo");
            this.comer();
        }

        public override void comer()
        {
            Console.WriteLine("Os sapos são carnívoros");
        }
    }
}
