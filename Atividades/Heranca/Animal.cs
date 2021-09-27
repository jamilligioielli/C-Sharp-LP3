using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine(" - > Animal");
            
        }

        public virtual void comer()
        {
            Console.WriteLine("Animais são classificados em: ");
            Console.WriteLine("1. Herbívoros: comem plantas; ");
            Console.WriteLine("2. Onívoros: comem plantas e outros animais;");
            Console.WriteLine("3. Canívoros: comem outros animais");
        }
    }
}
