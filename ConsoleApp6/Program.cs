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
            // lista för stora ägare
            List<Owner> owners = new List<Owner>();

            Console.WriteLine("skriv  information om ägare och katt (tryck på Enter för att avsluta).");

            string ownerName;
            do
            {
                Console.WriteLine("skriv ägare namn:");
                ownerName = Console.ReadLine();

                if (!string.IsNullOrEmpty(ownerName))
                {
                    //skappar en ny owner object och tilläger ägaren till listan
                    Owner owner = new Owner(ownerName);
                    owners.Add(owner);

                    string catName;
                    do
                    {
                        Console.WriteLine("skriv kattens namn (eller tryck på Enter för att avsluta tillägget av katter för den här ägaren).:");
                        catName = Console.ReadLine();

                        if (!string.IsNullOrEmpty(catName))
                        {
                            Console.WriteLine("skriv år:");
                            int år;
                            // parsen året
                            if (!int.TryParse(Console.ReadLine(), out år))
                            {
                                Console.WriteLine("fel år skriv år igen.");
                                continue;
                            }

                            Console.WriteLine("skriv ras:");
                            string breed = Console.ReadLine();
                            // skapar cat objekt
                            Cat cat = new Cat(catName, år, breed);
                            // lägger till cat till ägar listan of djur
                            owner.Pets.Add(cat);
                        }
                    } while (!string.IsNullOrEmpty(catName));
                }
            } while (!string.IsNullOrEmpty(ownerName));

           
            Console.WriteLine("ägare och katter:");
            foreach (var owner in owners)
            {
                Console.WriteLine(owner);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}




