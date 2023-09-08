using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidsProject.BL;
using MidsProject.DL;

namespace MidsProject.UI
{
    class libraryui
    {
        public static void borrowhistory()
        {
            //loadborrowdata(stu);
            Console.Clear();
            menusui.header();
            Console.WriteLine("Borrow History....");
            Console.WriteLine();
            bool t = librarydl.Borrowhis();
            if (t == false)
            {
                Console.WriteLine();
                Console.WriteLine("No books has been borrowed yet.................");
            }
            if (t == true)
            {
                Printborrowhis();
            }
            menusui.clear();
            menusui.header();
        }
        public static void Printborrowhis()
        {

            Console.WriteLine("Borrowed books             Users");
            librarydl.Printborrowhistory();
        }
        public static void printhistory(librarybl stu)
        {
            Console.WriteLine("   " + stu.getborrow() + "<<<<<<>>>>>>>" + stu.getborrowuser());
        }
        public static void Returnbook()
        {
            // saveuserdata();
            // savebooksdata();
            Console.Clear();
            menusui.header();
            string rbk, rbnm;
            bool et = false;
            Console.WriteLine("Return Books....");
            Console.WriteLine();
            bool check = librarydl.Borrowhis();
            if (check == false)
            {
                Console.WriteLine("No books borrowed");
            }
            else
            {
                bool c = librarydl.returnbook();
                if (c == true)
                {
                    Console.WriteLine("Book Has been returrned..........");
                }
                else
                {
                    Console.WriteLine("Enter Correct Name oof book");
                }
            }
            menusui.clear();
            menusui.header();
        }
    }
}
