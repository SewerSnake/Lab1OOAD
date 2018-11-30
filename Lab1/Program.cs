using System;

namespace Lab1
{
    class Program
    {
        static bool shouldQuit;

        static string input;

        static TextStorage storage = new TextStorage();

        static Command command = new Command();


        static void Main(string[] args)
        {
            shouldQuit = false;

            RunProgram();
        }

        /**
         * Runs the program until the user decides to quit.
        */
        static void RunProgram()
        {
            while (!shouldQuit)
            {
                Console.WriteLine($"\nCurrent text: {storage.GetText()}\n");
                GetUserCommand();
            }
        }

        /**
         * Gets the user's input. if it corresponds to 
         * one of the three command words, that method
         * is called. If nothing matched, the program 
         * informs the user of this.
        */
        static void GetUserCommand()
        {
            PrintMenu();

            input = Console.ReadLine().ToLower();

            switch(input)
            {
                case "add":
                    Add();
                    break;
                case "undo":
                    Undo();
                    break;
                case "redo":
                    Redo();
                    break;
                case "quit":
                    Quit();
                    break;
                default:
                    Console.WriteLine("Not a valid command... Please try again!\n");
                    break;
            }
        }

        /**
         * Prints all of the menu options to console.
        */
        static void PrintMenu()
        {
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("add");
            Console.WriteLine("undo");
            Console.WriteLine("redo");
            Console.WriteLine("quit\n");
        }

        /**
         * Makes a backup of what the user enters
         * in the console. The text is added to 
         * the TextStorage object.
        */
        static void Add()
        {
            Console.Write("\nEnter text here: ");

            input = Console.ReadLine();

            command.MakeBackup(storage);
           
            storage.SetText(input);
        }

        /**
         * Uses an instance of the Command class to 
         * retrieve an older SnapShot from stack.
        */
        static void Undo()
        {
            command.Undo();
        }

        /**
         * Uses an instance of the Command class to
         * retrieve a newer SnapShot from stack.
        */
        static void Redo()
        {
            command.Redo();
        }

        /**
         * Terminates program execution
         */
        static void Quit()
        {
            Console.Write("\nExiting program...");
            shouldQuit = true;
        }
    }
}
