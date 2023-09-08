using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidsProject.BL;
using MidsProject.UI;

namespace MidsProject.DL
{
    class userdl
    {
        public static List<userbl> stu1 = new List<userbl>();
        public static bool signincheck(userbl s)
        {
            string options = "", option1 = "";
            bool t = false;
            if (s.getname() == stu1[0].getname() && s.getpasswor() == stu1[0].getpasswor())
            {
                userui.Adminoptions(options);
                return true;
            }
            for (int x = 1; x < stu1.Count; x++)
            {
                if (s.getname() == stu1[x].getname() && s.getpasswor() == stu1[x].getpasswor())
                {
                    stu1[x].setindex(x);
                    userui.Studentoptions(option1);
                    return true;
                }

            }
            return false;
        }
        public static bool existeduser(string cname)
        {
            bool at = false;
            for (int d = 0; d < stu1.Count; d++)
            {

                if (stu1[d].getname() == cname)
                {
                    at = true;
                    return at;
                }
            }
            return at;
        }
        public static void adduserlist(userbl s)
        {
            stu1.Add(s);
        }
        public static bool checkremoveuser(string rmuser)
        {
            for (int i = 1; i <= stu1.Count; i++)
            {
                if (rmuser == stu1[i].getname())
                {
                    stu1.RemoveAt(i);
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }

        public static bool CheckAdmin(ref string e, ref string f)
        {
            if (e == stu1[0].getname() && f == stu1[0].getpasswor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool check(ref string c, ref string d)
        {
            for (int y = 0; y < stu1.Count; y++)
            {
                if (c == stu1[y].getname())
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }
            return true;
        }
        public static bool USERLIST()
        {
            if (stu1.Count > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void PRINTUSERLIST()
        {
            Console.WriteLine("   Username       Password");
            Console.WriteLine();
            for (int x = 1; x < stu1.Count; x++)
            {
                userui.printuserList(stu1[x]);
            }
        }

        public static void Changeuseridpassword(string x, string y)
        {
            for (int i = 1; i < stu1.Count; i++)
            {
                userbl s = new userbl();
                while (s.getpasswor().Length < 8)
                {
                    if (x == stu1[i].getname() && y == stu1[i].getpasswor())
                    {
                        s = userui.changepassinput();
                        if (s.getpasswor().Length < 8)
                        {
                            userui.passerror();
                            menusui.clear();
                        }
                        if (s.getpasswor().Length >= 8)
                        {
                            stu1[i].setname(s.getname());
                            stu1[i].setpassword (s.getpasswor());
                            userui.updatemsg();
                            //saveuserdata(stu1);
                            break;

                        }
                    }
                    if (i < stu1.Count)
                    {
                        continue;
                    }
                    else if (i >= stu1.Count)
                    {
                        userui.credential();
                        break;
                    }
                }
            }
        }
    }
}
