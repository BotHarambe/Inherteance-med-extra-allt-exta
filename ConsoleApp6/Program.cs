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
            // variabler 
            string namn;
            bool årtal = false;
            int år = 0;

            Console.WriteLine("Skriv namn");
            namn = Console.ReadLine(); // Läser namnet och lagrar i varibalen "namn"

            // Skapar en ny instans 
            Cat myCat = new Cat(namn, år);

            // forsätter tills årtal blir true och jag skrev korrekt år
            while (!årtal) {
                Console.WriteLine("Skriv år");
               if (int.TryParse(Console.ReadLine(), out int År)) {
                    
                    myCat.År = År;
                    
                    årtal = true;
                }

                else
                {
                    Console.WriteLine("du skrev fel fixa");
                }
            }
            
       
       

            Console.WriteLine("Namn = " + myCat.Namn);
            Console.WriteLine("år = " + myCat.År);


            Console.ReadLine();
        }

    }
}

