using System;
using System.Collections;


namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList nums = new ArrayList();
            int x;
            Console.WriteLine("Digite os números: ");
            for (int i = 0; i <= nums.Count; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x > 0)
                {
                    nums.Add(x);
                   
                }
                else
                {
                    break;
                }
            }
        
                int max = (int)nums[0];
                int min = (int)nums[0];
                for (int i = 1; i < nums.Count; i++)
                {
                    if ((int)nums[i] > max)
                    {
                        max = (int)nums[i];

                    }

                    else if ((int)nums[i] < min)
                    {
                        min = (int)nums[i];
                    }
                
                }
            Console.WriteLine("O maior número da lista é " + max);
            Console.WriteLine("O menor número da lista é " + min);



        }
    }
}