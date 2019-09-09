using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAnimalShelter
{

    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Colour { get; set; }


        public Animal()
        {

        }
        public Animal(string name, string type, string colour)
        {
            Name = name;
            Type = type;
            Colour = colour;
        }
        
    }
}
