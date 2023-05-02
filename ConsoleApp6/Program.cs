using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool årtal = false;
            Cat myCat = new Cat();
            Console.WriteLine("Skriv namn");
            myCat.Namn = Console.ReadLine() ;

            while (!årtal) {
                Console.WriteLine("Skriv år");
               if (int.TryParse(Console.ReadLine(), out int år)) {
                    
                    myCat.år = år;
                    årtal = true;
                }

                else
                {
                    Console.WriteLine("du skrev fel fixa");
                }
            }
            
            Console.WriteLine("Namn = " + myCat.Namn);
            Console.WriteLine("år = " + myCat.år);


            Console.ReadLine();
        }

    }
}

