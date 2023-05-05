using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //klass animal med egenskaper namn och år
    public class Animal
    {
        public string Namn { get; set; }
        public int År { get; set; }

    }

    // annan class Cat som ärver från animal
    public class Cat : Animal
    {
        // Konbsturktor som tar in namn och ålder och ställer i dem i Animal klassen
        public Cat(string namn, int age)
        {
            Namn = namn;
            År = age;
        }
   
    }

    
}
