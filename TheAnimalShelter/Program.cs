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
            var shelter = new Shelter(5);
            shelter.Animals.Insert(0, new Animal("Alfa", "Cat", "White"));
            shelter.Animals.Add(new Animal("Mruczek", "Cat", "Black"));

            shelter.Animals.Insert(1, new Animal("Beta", "Dog", "Brown"));
            shelter.Animals.Add(new Animal("Suczka", "Dogo", "Red"));
            shelter.Animals.Add(new Animal("Kajtek", "Dog", "BlackWhite"));

            //var allAnimals = shelter.Animals.Where(p => p.Type == "Cat");
            // string answer = Console.ReadLine();

            do
            {
                // welcome text
                Console.WriteLine("Welcome in AnimalShelter Management System!");
                Console.WriteLine("Type ADD to add a new animal, type DELETE to delete animal from database, type STATUS to check current status of the shelter.");
                var answer = Console.ReadLine();
                var freeSlots = shelter.Capacity - shelter.Animals.Count;

                //switch
                switch (answer)
                {
                    // adding new animal
                    case "ADD":
                    case "add":
                        {
                            if (freeSlots > 0)
                            {
                                Console.WriteLine("Enter the NAME of a new animal: ");
                                string newAnimalName = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Enter the TYPE of a new animal: ");

                                string newAnimalType = Console.ReadLine();

                                Console.WriteLine();
                                Console.WriteLine("Enter the COLOUR of a new animal: ");
                                string newAnimalColour = Console.ReadLine();

                                shelter.Animals.Add(new Animal(newAnimalName, newAnimalType, newAnimalColour));
                                Console.WriteLine("Added a new animal!");
                            }
                            else
                            {
                                Console.WriteLine("The shelter is full!");
                                break;
                            }

                            break;
                        }

                    // deleting animal from list
                    case "DELETE":
                    case "delete":

                        {
                            //loop showing current list
                            foreach (var item in shelter.Animals)
                            {
                                Console.WriteLine($"  [{shelter.Animals.IndexOf(item)}]  - Name: {item.Name}, Type: {item.Type}, Colour: {item.Colour}");
                            }
                            Console.WriteLine("Which animal would you like to remove? Type the number");
                            string animalDelete = Console.ReadLine();
                            shelter.Animals.RemoveAt(Convert.ToInt32(animalDelete));
                            Console.WriteLine();

                            //loop showing current list
                            foreach (var item in shelter.Animals)
                            {
                                Console.WriteLine($"  [{shelter.Animals.IndexOf(item)}]  - Name: {item.Name}, Type: {item.Type}, Colour: {item.Colour}");
                            }

                            break;
                        }


                    // checking shelter status
                    case "STATUS":
                    case "status":

                        {
                            Console.WriteLine($"Animals in Shelter: {shelter.Animals.Count}/{shelter.Capacity}.");
                            Console.WriteLine();
                            Console.WriteLine($"Empty cages: {shelter.Capacity - shelter.Animals.Count}.");
                            Console.WriteLine();
                            Console.WriteLine("These animals are currently in Shelter: ");

                            //loop showing current list
                            foreach (var item in shelter.Animals)
                            {
                                Console.WriteLine($"  [{shelter.Animals.IndexOf(item)}]  - Name: {item.Name}, Type: {item.Type}, Colour: {item.Colour}");
                            }
                            break;
                        }
                    case "END":
                    case "end":
                        {
                            // closing console window
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        Console.WriteLine("ERROR! Wrong command!");
                        break;
                }

            }
            while (true);



        }






    }
}

