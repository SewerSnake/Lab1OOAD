using System;

namespace Lab1
{
    class Program
    {
        static bool shouldQuit;

        static TextStorage storage;

        static Command command;


        static void Main(string[] args)
        {
            shouldQuit = false;
            storage = new TextStorage();
            command = new Command();
            RunProgram();
        }

        /**
         * Runs the program until the user decides to quit.
        */
        static void RunProgram()
        {
            while (!shouldQuit)
            {
                Console.WriteLine($"Current text: {storage.GetText()}\n");
                GetUserCommand();
            }
        }

        static void GetUserCommand()
        {
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("add");
            Console.WriteLine("undo");
            Console.WriteLine("quit\n");

            string input = Console.ReadLine().ToLower();

            switch(input)
            {
                case "add":
                    Add();
                    break;
                case "undo":
                    Undo();
                    break;
                case "quit":
                    Quit();
                    break;
                default:
                    Console.WriteLine("Please try again...\n");
                    break;
            }
        }

        static void Add()
        {
            String textToAdd = Console.ReadLine();
            Console.Write("\nEnter text here: ");

            textToAdd = Console.ReadLine();

            if (storage.GetText() != null)
            {
                command.MakeBackup(storage);
            }

            storage.SetText(textToAdd);
        }

        static void Undo()
        {
            command.Undo();
        }

        static void Quit()
        {
            Console.Write("\nExiting program...");
            shouldQuit = true;
        }
    }
}
