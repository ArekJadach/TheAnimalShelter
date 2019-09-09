using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAnimalShelter
{
    class Program
    {
        public static void Main(string[] args)
        {

            #region Nauka z Danielem
            //var shelter = new Shelter();
            //shelter.Capacity = 20;
            //var shelter2 = new Shelter(20);

            //var shelter3 = new Shelter
            //{
            //    Capacity = 20
            //};

            //var nosacz = new Animal()
            //{
            //    Colour = "brown",
            //    Name = "Janusz",
            //    Type = "orangutan"
            //};


            //shelter3.Animals.Add(nosacz);
            //shelter3.Animals.Insert(0, new Animal("kicius", "cat", "white")); //dodaje na liście na określony index
            //shelter3.Animals.Add(new Animal("tygrysek", "cat", "brown"));
            //Console.WriteLine(shelter3.Animals[0].Name);

            //var kittens = shelter3.Animals.Where(p => p.Type == "cat");

            //var isThereKitten = shelter3.Animals.Any(p => p.Type.Contains("cat"));  // czy Typ zawiera 3 litery obok siebie "cat"
            //Console.WriteLine("Czy jest kot?: {0}", isThereKitten.ToString());

            //foreach (var item in kittens)
            //{
            //  Console.WriteLine($"Name: {item.Name}, Type: {item.Type}, Colour: {item.Colour}");


            //    //Console.WriteLine("Name: {0}, Type: {1}, Colour: {2}", item.Name, item.Type, item.Colour);
            //}


            //Console.WriteLine(shelter2.Capacity);


            ////Console.WriteLine(kitty.FirstOrDefault().Name); 
            #endregion
            var shelter = new Shelter(20);
            shelter.Animals.Insert(0, new Animal("Alfa", "Cat", "White"));
            shelter.Animals.Add(new Animal("Mruczek", "Cat", "Black"));

            shelter.Animals.Insert(1, new Animal("Beta", "Dog", "Brown"));
            shelter.Animals.Add(new Animal("Suczka", "Dogo", "Red"));
            shelter.Animals.Add(new Animal("Kajtek", "Dog", "BlackWhite"));

            var allAnimals = shelter.Animals.Where(p => p.Type == "Cat");

            //foreach (var item in allAnimals)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Type: {item.Type}, Colour: {item.Colour}");
            //}
            Console.WriteLine("Welcome in AnimalShelter Management System!");
            Console.WriteLine("Type ADD to add a new animal, type DELETE to delete animal from database, type STATUS to check current status of the shelter.");
            var answer = Console.ReadLine();



            Console.WriteLine($"Animals in Shelter: {shelter.Animals.Count}/{shelter.Capacity}.");
            Console.WriteLine();
            Console.WriteLine($"Empty cages: {shelter.Capacity - shelter.Animals.Count}.");
            Console.WriteLine();
            Console.WriteLine("These animals are currently in Shelter: ");

            foreach (var item in shelter.Animals)
            {
                Console.WriteLine($"Name: {item.Name}, Type: {item.Type}, Colour: {item.Colour}");
            }




        }
    }
}
