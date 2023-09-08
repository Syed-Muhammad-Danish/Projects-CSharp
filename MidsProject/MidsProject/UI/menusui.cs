using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MidsProject.BL;
using MidsProject.DL;


namespace MidsProject.UI
{
    class menusui
    {
        public static void about()
        {
            Console.Clear();
            header();
            Console.WriteLine("About library....");
            Console.WriteLine();
            Console.WriteLine("About Us:");
            Console.WriteLine("Our library is dedicated to providing a welcoming and inclusive space for all members of the community. With a collection of books, periodicals, and other resources, we aim to be a hub of learning and discovery. Our librarians are knowledgeable and passionate about helping patrons find the information they need, and our facilities are equipped with the latest technology to support research and educational pursuits. Whether you're a student, a lifelong learner, or simply someone ooking for a quiet place to read, our library is here to serve you. We believe that access to information and knowledge is a fundamental right, and we work every -day to make that a reality for everyone.");
            Console.WriteLine();
            Console.WriteLine("Contact Us:");
            Console.WriteLine("Email: lib@uet.edu.pk                Website: https://library.uet.edu.pk ");
            clear();
            header();
        }
        public static string mainpage()
        {
            Console.Clear(); ;
            header();
            string option;
            Console.WriteLine("Welcome....");
            Console.WriteLine();
            Console.WriteLine(" Enter Any oF The Following: ");
            Console.WriteLine(" 1. Sign In: ");
            Console.WriteLine(" 2. Sign Up: ");
            Console.WriteLine(" 3. Exit: ");
            Console.WriteLine();

            Console.Write("Select option: ");
            option = Console.ReadLine();
            return option;
        }
        public static string adminmenu()
        {

            string options;
            Console.Clear();
            header();
            Console.WriteLine("Welcome to Admin menu");
            Console.WriteLine("_________________________.");
            Console.WriteLine("Select One Of the Following:");
            Console.WriteLine("1.Add Books.");
            Console.WriteLine("2.Change Admin Username / Password.");
            Console.WriteLine("3.See user list.");
            Console.WriteLine("4.Remove User.");
            Console.WriteLine("5.See borrow history.");
            Console.WriteLine("6.View Books List.");
            Console.WriteLine("7.Remove Book.");
            Console.WriteLine("8.Change user ID and password.");
            Console.WriteLine("9.Return to Credentials Page.");
            Console.WriteLine("10.Close Program.");
            Console.WriteLine();
            Console.Write("Select the option: ");
            options = Console.ReadLine();
            return options;
        }
        public static string student()
        {
            string option1;
            Console.Clear();
            header();
            Console.WriteLine("Welcome to Student Menu");
            Console.WriteLine("__________________________.");
            Console.WriteLine("Select One Of the Following:");
            Console.WriteLine("1.Search Books.");
            Console.WriteLine("2.Search through author name.");
            Console.WriteLine("3.View List of All books.");
            Console.WriteLine("4.Change My Password.");
            Console.WriteLine("5.Borrow a book.");
            Console.WriteLine("6.View list of borrowed books.");
            Console.WriteLine("7.Enter name of book to return.");
            Console.WriteLine("8.View Fine.");
            Console.WriteLine("9.About Library.");
            Console.WriteLine("10.Credentials page.");
            Console.WriteLine("11.Close Program.");
            Console.WriteLine();
            Console.Write("Select the option: ");
            option1 = Console.ReadLine();
            return option1;
        }
        public static void loading()
        {
            Console.Clear();
            header();
            //HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
            //SetConsoleTextAttribute(hConsole, 10);

            char n = Convert.ToChar(166);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("   ||-------------------------------------------------------||");
            Console.WriteLine("   ||.--.    .-._                        .----.             ||");
            Console.WriteLine("   |||==|____| |H|___            .---.___|''''|_____.--.___ ||");
            Console.WriteLine("   |||  |====| | |xxx|_          |+++|=-=|_  _|-=+=-|==|---|||");
            Console.WriteLine("   |||==|    | | |   | \\         |   |   |_\\/_|Black|  | ^ |||");
            Console.WriteLine("   |||  |    | | |   |\\ \\   .--. |   |=-=|_/\\_|-=+=-|  | ^ |||");
            Console.WriteLine("   |||  |    | | |   |_\\ \\_( oo )|   |   |    |Magus|  | ^ |||");
            Console.WriteLine("   |||==|====| |H|xxx|  \\ \\ |''| |+++|=-=|''''|-=+=-|==|---|||");
            Console.WriteLine("   ||`--^----'-^-^---'   `-' ''  '---^---^----^-----^--^---^||");
            Console.WriteLine("   ||-------------------------------------------------------||");
            Console.WriteLine("   ||-------------------------------------------------------||");
            Console.WriteLine("   ||               ___                   .-.__.-----. .---.||");
            Console.WriteLine("   ||              |===| .---.   __   .---| |XX|<(*)>|_|^^^|||");
            Console.WriteLine("   ||         ,  /(|   |_|III|__|''|__|:x:|=|  |     |=| Q |||");
            Console.WriteLine("   ||      _a'{ / (|===|+|   |++|  |==|   | |  |Illum| | R |||");
            Console.WriteLine("   ||      '/\\/ _(|===|-|   |  |''|  |:x:|=|  |inati| | Y | ||");
            Console.WriteLine("   ||_____  -\\{___(|   |-|   |  |  |  |   | |  |     | | Z |||");
            Console.WriteLine("   ||       _(____)|===|+|[I]|DK|''|==|:x:|=|XX|<(*)>|=|^^^|||");
            Console.WriteLine("   ||              `---^-^---^--^--'--^---^-^--^-----^-^---^||");
            Console.WriteLine("   ||-------------------------------------------------------||");
            Console.WriteLine("   ||_______________________________________________________||");
            Console.WriteLine();
            Console.Write("              LOADING   ");
            for (int x = 0; x < 12; x++)
            {
                Thread.Sleep(500);
                Console.Write(n);
            }
            Thread.Sleep(2000);
        }
        public static void header()
        {
            //HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
            //SetConsoleTextAttribute(hConsole, 14);
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("*                                                                                                               *");
            Console.WriteLine("*   __    _ _                      _____                                   _      _____         _               *");
            Console.WriteLine("*  |  |  |_| |_ ___ __  ___ _ _   |     |___ ___ ___ ___ ___ _____ ___ ___| |_   |   __|_ _ ___| |_ ___ _____   *");
            Console.WriteLine("*  |  |__| | . |  _|..'|  _| | |  | | | | .'|   | .'| . | -_|     | -_|   |  _|  |__   | | |_ -|  _| -_|     |  *");
            Console.WriteLine("*  |_____|_|___|_| |__,|_| |_  |  |_|_|_|__,|_|_|__,|_  |___|_|_|_|___|_|_|_|    |_____|_  |___|_| |___|_|_|_|  *");
            Console.WriteLine("*                          |___|                    |___|                              |___|                    *");
            Console.WriteLine("*                                                                                                               *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine();

            //SetConsoleTextAttribute(hConsole, 7);
        }
        public static void clear()
        {

            Console.WriteLine("Press any Key to Continue ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
