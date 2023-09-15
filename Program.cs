using System.Data;
using Documents.Models;

namespace Documents
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. Basic\n2. Pro\n3. Expert\n4. Exit\n");
            Console.Write("Please Enter (1-4): ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string key = Console.ReadLine();
            Console.WriteLine();

            if (key == "1")
            {
                DocumentProgram docProgram = new DocumentProgram();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                docProgram.OpenDocument();
                docProgram.EditDocument();
                docProgram.SaveDocument();
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (key == "2")
            {
                DocumentProgram docProgram = new ProDocument();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                docProgram.OpenDocument();
                Console.WriteLine();
                docProgram.EditDocument();
                docProgram.SaveDocument();
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (key == "3")
            {
                DocumentProgram docProgram = new ExpertDocument();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                docProgram.OpenDocument();
                Console.WriteLine();
                docProgram.EditDocument();
                Console.WriteLine();
                docProgram.SaveDocument();
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (key == "4")
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press any key to Exit...");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(750);
                Console.WriteLine("Error! \nPlease Enter (1-4)");
                Thread.Sleep(2000);
                Console.WriteLine("\nPress any key to return Menu...");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }
    }
}