using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    public class Owner
    {
        public string Name { get; set; }
        public List<Cat> Pets { get; set; }

        public Owner(string name)
        {
            // intielars owner-objeket med ett namn
            Name = name;
            Pets = new List<Cat>();
        }

        public override string ToString()
        {
            string catList = "";
            foreach (var cat in Pets)
            {
                catList += cat.ToString() + "\n";
            }

            return $"Owner: {Name}\n{catList}";
        }
    }
}

