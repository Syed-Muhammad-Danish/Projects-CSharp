using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidsProject.BL;
using MidsProject.DL;

namespace MidsProject.UI
{
    class userui
    {
        public static void signin()
        {
            userbl s = new userbl();
            Console.Clear();
            menusui.header();
            Console.WriteLine("Welcome to signin page.............. :) ");
            Console.WriteLine("Note: If your admin enter only predefined admin id.");
            Console.WriteLine();
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Password: ");
            string password = Console.ReadLine();
            userbl signinup = new userbl(name, password);
            bool ty = userdl.signincheck(signinup);
            if (ty == false)
            {
                Console.WriteLine("User not found");
                Console.WriteLine();
                Console.WriteLine("Note: Maybe you have not signedup or your credentials are changed by admin. Contact admin if there is any problem in signing in your existed account.");
                menusui.clear();
            }
        }
        public static void signup()
        {
            userbl s = new userbl();
            Console.Clear();
            menusui.header();
            Console.WriteLine("Welcome to signup page.............. :) ");
            Console.WriteLine();
            string cname, cpass = "a";
            bool at = false;
            while (cpass.Length < 8)
            {
                bool chk = false;
                Console.Clear();
                menusui.header();
                Console.Write("Enter your Name: ");
                cname = Console.ReadLine();
                Console.Write("Enter your Password: ");
                cpass = Console.ReadLine();
                if (cpass.Length < 8)
                {
                    chk = true;
                    Console.WriteLine("Your PassWord is less than 8 Characters Try again");
                    Console.ReadKey();
                }
                if (chk == false)
                {
                    at = userdl.existeduser(cname);
                    if (at == true)
                    {
                        Console.WriteLine("user Existed.");
                        menusui.clear();
                    }
                    if (at == false)
                    {
                        userbl user = new userbl(cname, cpass);
                        userdl.adduserlist(user);
                        Console.WriteLine("New id has been created successfully...........");
                        //saveuserdata(stu1);
                        //savebooksdata(stu2);
                        //saveborrowdata(stu);

                    }
                }
            }
        }
        public static void userlist()
        {
            Console.Clear();
            menusui.header();
            Console.WriteLine("User List....");
            Console.WriteLine();
            bool t = userdl.USERLIST();
            if (t == false)
            {
                Console.WriteLine("No user existed.............");
            }
            else if (t == true)
            {
                userdl.PRINTUSERLIST();
            }
            menusui.clear();
            menusui.header();
        }
        public static void Adminoptions(string options)
        {
            bool t = true;
            while (t == true)
            {
                options = menusui.adminmenu();
                if (options == "1")
                {
                    booksui.addbooks();
                }
                if (options == "2")
                {
                    changeadminpas();
                }
                if (options == "3")
                {
                    userlist();
                }
                if (options == "4")
                {
                    removeuser();
                }
                if (options == "5")
                {
                    libraryui.borrowhistory();
                }
                if (options == "6")
                {
                    booksui.booklist();
                }
                if (options == "7")
                {
                    booksui.removebook();
                }
                if (options == "8")
                {
                    changepsiduser();
                }
                if (options == "10")
                {
                    //    saveuserdata(stu1);
                    //    savebooksdata(stu2);
                    //    saveborrowdata(stu);
                    menusui.clear();
                    Environment.Exit(0);
                }
                if (options == "9")
                {
                    t = false;
                }
            }
            menusui.clear();
        }
        public static void printuserList(userbl stu1)
        {
            Console.WriteLine("   " + stu1.getname() + "           " + stu1.getpasswor());
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
        public static void changeadminpas()
        {
            Console.Clear();
            menusui.header();
            string c = "a", d = "a", e, f;
            Console.WriteLine("Change Admin id and Password....");
            Console.WriteLine();
            Console.Write("Enter old admin name: ");
            e = Console.ReadLine();
            Console.Write("Enter old admin password: ");
            f = Console.ReadLine();
            bool t = userdl.CheckAdmin(ref e, ref f);
            if (t == true)
            {
                while (d.Length < 8)
                {
                    Console.Write("Enter new admin name: ");
                    c = Console.ReadLine();
                    Console.Write("Enter new admin password: ");
                    d = Console.ReadLine();


                    if (d.Length < 8)
                    {
                        Console.WriteLine("Password Should be 8 Characters long.");
                        menusui.clear();
                    }
                }
                if (d.Length >= 8)
                {
                    bool n = userdl.check(ref c, ref d);
                    if (n == false)
                    {
                        Console.WriteLine("ID and Password Already existed......");
                        Console.ReadKey();
                    }
                    if (n == true)
                    {
                        Console.WriteLine("Id and Password has been changed..........");
                        userdl.stu1[0].setname(c);
                        userdl.stu1[0].setpassword(d);
                        //saveuserdata(stu1);
                    }
                }
            }
            if (t == false)
            {
                Console.WriteLine("Enter correct old Id and password.........");
            }
            menusui.clear();
            menusui.header();
        }
        public static void changepsiduser()
        {
            Console.Clear();
            menusui.header();
            Console.WriteLine("Change User Id and Password....");
            Console.WriteLine();
            string w, x, y, z = "";

            bool t = userdl.USERLIST();
            if (t == true)
            {
                Console.Write("Enter Name(Id):");
                x = Console.ReadLine();
                Console.Write("Enter Password:");
                y = Console.ReadLine();
                bool s = librarydl.check(x);
                if(s == true)
                {
                    userdl.Changeuseridpassword(x, y);
                }
                else
                {
                    Console.WriteLine("User Has books to retrun. You cant change his/her ID");
                }
            }
            if (t == false)
            {
                Console.WriteLine("No user Existed........");
            }
            menusui.clear();
            menusui.header();
        }
        public static userbl changepassinput()
        {
            userbl s = new userbl();
            Console.Write("Enter New ID:");
            s.setname(Console.ReadLine());
            Console.Write("Enter New password:");
            s.setpassword(Console.ReadLine());

            return s;
        }
        public static void credential()
        {
            Console.WriteLine("Enter Correct Credentials.....");
        }
        public static void idpasserror()
        {
            Console.WriteLine("Id password has been taken......");
        }
        public static void updatemsg()
        {
            Console.WriteLine("ID and Password has been updated.........");
        }
        public static void passerror()
        {
            Console.WriteLine("Password Should be 8 Characters long.");
        }
        public static void Studentoptions(string option1)
        {
            bool t = true;
            while (t == true)
            {
                option1 = menusui.student();
                if (option1 == "1")
                {
                    search();
                }
                if (option1 == "2")
                {
                   booksui.searchauthor();
                }
                if (option1 == "3")
                {
                    booksui.booklist();
                }
                if (option1 == "4")
                {
                    userrpasswrd();
                }
                //if (option1 == "5")
                //{
                //    borrowbook();
                //}
                if (option1 == "6")
                {
                    Borrowedbook();
                }
                if (option1 == "7")
                {
                    libraryui.Returnbook();
                }
                if (option1 == "8")
                {
                    viewfine();
                }
                if (option1 == "9")
                {
                    menusui.about();
                }
                if (option1 == "11")
                {
                    //saveuserdata();
                    //savebooksdata();
                    //saveborrowdata();
                    menusui.clear();
                    Environment.Exit(0);
                }
                if (option1 == "10")
                {
                    t = false;
                }
            }


        }
        public static void viewfine()
        {
            Console.Clear();
            menusui.header();
            Console.WriteLine("     View Fine ");
            Console.WriteLine();
            Console.WriteLine("-----------------------.");
            Console.WriteLine();
            bool t = false;
            t = librarydl.printfine();
            if (t == false)
            {
                Console.WriteLine("No book Has been borrowed..............");
            }

            menusui.clear();
            menusui.header();
        }
        public static void userrpasswrd()
        {
            Console.Clear();
            menusui.header();
            Console.WriteLine("Change User Id and Password....");
            Console.WriteLine();
            string w, x, y, z = "";

            bool t = userdl.USERLIST();
            if (t == true)
            {
                Console.Write("Enter Name(Id):");
                x = Console.ReadLine();
                Console.Write("Enter Password:");
                y = Console.ReadLine();
                bool s = librarydl.check(x);
                if (s == true)
                {
                    userdl.Changeuseridpassword(x, y);
                }
                else
                {
                    Console.WriteLine("User Has books to retrun. You cant change his/her ID");
                }
            }
            if (t == false)
            {
                Console.WriteLine("No user Existed........");
            }
            menusui.clear();
            menusui.header();
        }
        public static void Borrowedbook()
        {
            // saveuserdata();
            // savebooksdata();
            // saveborrowdata();
            Console.Clear();
            menusui.header();
            string bnm;
            bool tas = false;
            int y = 0;
            Console.WriteLine("List Borrowed Books....");
            Console.WriteLine();
            bool check = librarydl.Borrowhis();
            if (check == false)
            {
                Console.WriteLine("No books borrowed");
            }
            else
            {
                tas = librarydl.Borrowed();
                if (tas == false)
                {
                    Console.WriteLine("No books are borrowed yet...........");
                }
            }
            menusui.clear();
            menusui.header();
        }

        public static void search()
        {
            Console.Clear();
            menusui.header();
            string seebknm;
            Console.WriteLine("Search Bar....");
            Console.WriteLine();
            bool t = bookdl.Booklist();
            if (t == true)
            {
                Console.Write("Enter name exact name of book to search:");
                seebknm = Console.ReadLine();
                bool ft = false;
                bool ra = false;
                if (ft == true)
                {
                    Console.WriteLine("Book is not available......");
                }
                if (ft == false)
                { 
                    ra = bookdl.Printsearch(seebknm);
                    if (ra == false)
                    {
                        Console.WriteLine("Enter correct name.....");
                    }
                }
            }
            if (t == false)
            {
                Console.WriteLine("Sorry no book is available uptill now............. :( ");
            }
            menusui.clear();
            menusui.header();
        }
    }
}
