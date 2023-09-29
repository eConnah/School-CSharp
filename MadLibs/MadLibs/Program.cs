using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an adjective: ");
            String Adjective = Console.ReadLine();
            Console.WriteLine("Please input a vehicle: ");
            String Vehicle = Console.ReadLine();
            Console.WriteLine("Please input a verb: ");
            String Verb = Console.ReadLine();
            Console.WriteLine("Please input a colour: ");
            String Colour = Console.ReadLine();
            Console.WriteLine("Please input a food: ");
            String FoodOne = Console.ReadLine();
            Console.WriteLine("Please input another food: ");
            String FoodTwo = Console.ReadLine();
            Console.WriteLine("Please input a name: ");
            String Name = Console.ReadLine();
            Console.WriteLine("Please input a saying: ");
            String Saying = Console.ReadLine();
            Console.WriteLine($"Today I went to my favorite Taco Stand called the {Adjective} animal.");
            Console.WriteLine($"Unlike most food stands, they cook and prepare the food in a {Vehicle} while you {Verb}.");
            Console.WriteLine($"The best thing on the menu is the color {Colour}.");
            Console.WriteLine($"Instead of ground beef, they fill the taco with {FoodOne}, cheese, and top it off with a salsa made from {FoodTwo}.");
            Console.WriteLine($"If that doesn't make your mouth water, then it's just like {Name} always says: {Saying}");
        }
    }
}