using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Menu!");

        bool running = true;
        while (running)
        {
            // Display the menu options
            Console.WriteLine("1. Option 1");
            Console.WriteLine("2. Option 2");
            Console.WriteLine("3. Option 3");
            Console.WriteLine("4. Exit");

            // Prompt the user for input
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            // Process the user's choice
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Option 1 selected");
                    // Perform action for option 1
                    break;
                case "2":
                    Console.WriteLine("Option 2 selected");
                    // Perform action for option 2
                    break;
                case "3":
                    Console.WriteLine("Option 3 selected");
                    // Perform action for option 3
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine(); // Add a new line for spacing
        }
    }
}
