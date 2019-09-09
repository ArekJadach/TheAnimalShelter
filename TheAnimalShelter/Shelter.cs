using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAnimalShelter
{
    public class Shelter
    {
        public List<Animal> Animals { get; set; }
        public int Capacity { get; set; }

        public Shelter()
        {
            Animals = new List<Animal>();
        }

        public Shelter(int capacity)
        { 
            Capacity = capacity;
            Animals = new List<Animal>();
        }
    }
    

}
