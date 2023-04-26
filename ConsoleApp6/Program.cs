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
            Cat myCat = new Cat();
            myCat.Name = "Fluffy";
            myCat.Age = 5;
            
            Console.WriteLine("Namn" + myCat.Name);
            Console.WriteLine("år" + myCat.Age);


            Console.ReadLine();
        }

    }
}

