using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Animal
    {
        public string Namn { get; set; }
        public int År { get; set; }

    }

    public class Cat : Animal
    {
        public Cat(string namn, int age)
        {
            Namn = namn;
            År = age;
        }
   
    }

    
}
