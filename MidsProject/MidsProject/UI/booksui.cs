using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidsProject.BL;
using MidsProject.DL;

namespace MidsProject.UI
{
    class booksui
    {
        public static void addbook(string choice)
        {


            Console.Write("Enter name of book: ");
            string book = Console.ReadLine();
            Console.Write("Enter author name: ");
            string author= Console.ReadLine();
            Console.Write("Enter PublishYear name: ");
            string publishdate = Console.ReadLine();
            if(IsYearValid(publishdate))
            {
                bookbl s = new bookbl(book,author,publishdate,choice);
                bookdl.addbooklist(s);
            }
            else
            {
                Console.WriteLine("Invalid Input");

            }

        }
        public static void Printbook(bookbl s)
        {
            Console.WriteLine(s.getbooks() + " by " + s.getauthor() +"     "+ s.getpublishdate()+" Book is available :).......");
        }
        public static bool IsYearValid(string input)
        {
            // Check if the input is a numeric value
            if (!int.TryParse(input, out int year))
            {
                return false;
            }

            // Check if the year is within a valid range (e.g., 1000 to 9999)
            if (year < 1000 || year > 9999)
            {
                return false;
            }

            return true;
        }
        public static string booktype1()
        {

            Console.WriteLine("Book Category");
            Console.WriteLine("----------------------");
            Console.WriteLine("Select Type of Book to Add......");
            Console.WriteLine("1. Islamic");
            Console.WriteLine("2. Academic");
            Console.WriteLine("3. Fictional");
            Console.WriteLine("4. Mangas");
            Console.WriteLine("5. Romantic");
            Console.WriteLine("Select :");
            string choice = Console.ReadLine();
            return choice;
        }
        public static string bookchoice()
        {
            string choice = booktype1();
            if (choice == "1")
            {
                return "Islamic";
            }
            else if (choice == "2")
            {
                return "Academic";
            }
            else if (choice == "3")
            {
                return "Fictional";
            }
            else if (choice == "4")
            {
                return "Mangas";
            }
            else if (choice == "5")
            {
                return "Romantic";
            }
            else
            {
                return "InValid";
            }
        }
        public static void addbooks()
        {

            Console.Clear();
            menusui.header();
            int size;
            Console.WriteLine("Add Books....");
            Console.WriteLine();
            string choice = bookchoice();
            if (choice != "InValid")
            {
                Console.WriteLine("Enter no. of books to add :");
                size = int.Parse(Console.ReadLine());
                for (int x = 0; x < size; x++)
                {
                    addbook(choice);
                }
                Console.WriteLine("Your books has been added");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            //savebooksdata(stu2);

            menusui.clear();
            menusui.header();
        }
        public static void booklist()
        {
            Console.Clear();
            menusui.header();
            Console.WriteLine("Book List....");
            Console.WriteLine();
            bool t = bookdl.Booklist();
            if (t == false)
            {
                Console.WriteLine("No books existed.............");
            }
            if (t == true)
            {
                Console.WriteLine("   Books name      Author name");
                bookdl.Printbooklist();
            }
            menusui.clear();
            menusui.header();
        }
        public static void printbookList(bookbl stu2)
        {
            Console.WriteLine("   " + stu2.getbooks() + "           " + stu2.getauthor());
        }
        public static void removeuser()
        {
            Console.Clear();
            menusui.header();
            string rmuser;
            Console.WriteLine("Remove User....");
            Console.WriteLine();
            bool t = userdl.USERLIST();
            if (t == true)
            {
                Console.Write("Enter name of user to remove: ");
                rmuser = Console.ReadLine();
                bool n = userdl.checkremoveuser(rmuser);
                if (n == true)
                {
                    Console.WriteLine("User has been removed sucessfully.............");
                    //saveuserdata(stu1);

                }
                else if (n == true)
                {
                    Console.WriteLine("User not found. << or >> Enter Correct Name.");
                }
            }
            if (t == false)
            {
                Console.WriteLine("No user existed.");
            }
            menusui.clear();
            menusui.header();
        }
        public static void removebook()
        {
            Console.Clear();
            menusui.header();
            string rmbknm, rmauthor;
            Console.WriteLine("Remove Book....");
            Console.WriteLine();
            bool t = bookdl.checkremovebook();
            if (t == true)
            {
                Console.Write("Enter Book name to remove:");
                rmbknm = Console.ReadLine();
                Console.Write("Enter name of author of book:");
                rmauthor = Console.ReadLine();
                bool n = bookdl.CheckRemovebook(rmbknm, rmauthor);
                if (n == true)
                {
                    Console.WriteLine("Book has been removed sucessfully.............");
                    //savebooksdata(stu2);

                }
                else if (n == false)
                {
                    Console.WriteLine("Book not found. << or >> Enter Correct Name.");
                }
            }
            if (t == false)
            {
                Console.WriteLine("No book is available in library");
            }
            menusui.clear();
            menusui.header();
        }
        public static void searchauthor()
        {
            Console.Clear();
            menusui.header();
            string seeauth;
            Console.WriteLine("Author Search Bar....");
            Console.WriteLine();
            bool t = bookdl.Booklist();
            if (t == true)
            {
                Console.Write("Enter correct name of author:");
                seeauth = Console.ReadLine();
                bool ta = false;
                Console.WriteLine("Author        books");
                ta = bookdl.Printauthsearch(seeauth);
                if (ta == false)
                {
                    Console.WriteLine("No book of this author is available in Library............");
                }
            }
            if (t == false)
            {
                Console.WriteLine("Sorry no book is available uptill now............. :( ");
            }
            menusui.clear();
            menusui.header();
        }
        public static void Printauth(bookbl s)
        {
            Console.WriteLine(s.getauthor() + " >>><>>>> " + s.getbooks());
            Console.WriteLine(s.getbooks() + " by " + s.getauthor() + "     " +s.getpublishdate()+"   "+" Book is available :).......");
        }


    }
}
