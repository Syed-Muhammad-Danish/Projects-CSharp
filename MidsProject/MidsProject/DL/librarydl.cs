using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidsProject.BL;
using MidsProject.UI;

namespace MidsProject.DL
{
    class librarydl
    {

        public static List<librarybl> stu = new List<librarybl>();
        public static bool check(string x)
        {
            for (int i = 1; i < stu.Count; i++)
            {
                if(stu[i].getborrowuser() == x)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool Borrowed()
        {  
            int y = 0;
            userbl s = new userbl();
            for (int t = 0; t < stu.Count; t++)
            {
                if (userdl.stu1[s.getindex()].getname() == stu[t].getborrowuser())
                {
                    y++;
                }
                if (y == 0 && userdl.stu1[s.getindex()].getname() == stu[t].getborrowuser())
                {

                    return false;
                }
                if (y != 0 && userdl.stu1[s.getindex()].getname() == stu[t].getborrowuser())
                {
                    Console.WriteLine(stu[t].getborrow() + " has been borrowed........");
                    return true;
                }
            }
            return false;
        }
        public static bool returnbook()
        {
            string rbk;
            Console.Write("Enter name of book to return:");
            rbk = Console.ReadLine();
            for (int i = 0; i < stu.Count; i++)
            {
                if (rbk == stu[i].getborrow())
                {
                    stu.RemoveAt(i);
                    Console.WriteLine("Fine :" + Printfines(i));
                    return true;
                    //saveborrowdata();
                }
            }
            return false;


        }
        public static bool printfine()
        {
            userbl s = new userbl();
            for (int i = 0; i < stu.Count; i++)
            {
                if (userdl.stu1[s.getindex()].getname() == stu[i].getborrowuser())
                {
                    //currenttime();
                    int x = Printfines(i);
                    Console.WriteLine("Fine : " + x);
                    return true;
                }
            }
            return false;
        }
        public static int Printfines(int i)
        {

            int totaldays = 0;
            int fines = 0;
            totaldays = (((DateTime.Now.Month - stu[i].getmonth()) * 30) + (DateTime.Now.Day - stu[i].getdate()));
            if (stu.Count != 0)
            {
                if (totaldays > 10)
                {
                    int sum = 0;
                    sum = (totaldays - 10);
                    if (sum < 3)
                    {
                        fines = 1000;
                        return fines;
                    }
                    else
                    {
                        fines = (1000 + (sum * 100));
                        return fines;
                    }
                }
                if (totaldays < 10)
                {
                    fines = 0;
                    return fines;
                }
                else
                {
                    Console.WriteLine("No fine is shown.........");

                }
            }
            return fines;
        }

        public static bool Borrowhis()
        {
            if (stu.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Printborrowhistory()
        {
            for (int i = 0; i < stu.Count; i++)
            {
                libraryui.printhistory(stu[i]);
            }
        }
    }
}
