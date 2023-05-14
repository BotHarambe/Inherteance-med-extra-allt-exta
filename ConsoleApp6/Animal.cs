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

    public class Cat : Animal
    {
        public string Ras { get; set; }

        public Cat(string name, int age, string breed)
        {
            Namn = name;
            År = age;
            Ras = breed;
        }

        public override string ToString()
        {
            // generar en string repestrion of Cat klassen
            return $"Katt: {Namn}, År: {År}, Ras: {Ras}";
        }
    }
}