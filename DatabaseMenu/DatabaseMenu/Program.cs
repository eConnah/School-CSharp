using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Simple database (a list of strings)
        List<string> database = new List<string>();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine()?.ToLower();

            switch (choice)
            {
                case "1":
                case "add":
                    Console.Write("Enter a value to add: ");
                    string valueToAdd = Console.ReadLine();
                    database.Add(valueToAdd);
                    Console.WriteLine("Value added successfully.");
                    break;

                case "2":
                case "delete":
                    Console.Write("Enter a value to delete: ");
                    string valueToDelete = Console.ReadLine();
                    if (database.Remove(valueToDelete))
                        Console.WriteLine("Value deleted successfully.");
                    else
                        Console.WriteLine("Value not found in the database.");
                    break;

                case "3":
                case "update":
                    Console.Write("Enter the old value to update: ");
                    string oldValue = Console.ReadLine();
                    Console.Write("Enter the new value: ");
                    string newValue = Console.ReadLine();
                    int index = database.IndexOf(oldValue);
                    if (index != -1)
                    {
                        database[index] = newValue;
                        Console.WriteLine("Value updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Old value not found in the database.");
                    }
                    break;

                case "4":
                case "display":
                    Console.WriteLine("Database contents:");
                    foreach (string item in database)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case "5":
                case "quit":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please enter a valid option (1-5).");
                    break;
            }

            Console.WriteLine();
        }
    }
}
