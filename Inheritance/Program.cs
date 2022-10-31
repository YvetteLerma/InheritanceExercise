using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.DoMigrate = true;
            myBird.BeakLength = 3.5;

            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "swamp",
                CanGrowTail = true
            };

            var myAnimals = new Animal[] { myBird, lizard };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Am I alive: {animal.IsAlive}");
                Console.WriteLine($"I am {animal.Age} years old.");
                Console.WriteLine($"I have {animal.LegCount} legs.");
                Console.WriteLine($"I live by {animal.LandSeaAir}");
                Console.WriteLine($"What am I?");
                Console.WriteLine($"");
            }
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
