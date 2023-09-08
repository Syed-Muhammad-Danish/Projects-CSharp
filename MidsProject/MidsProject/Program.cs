using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidsProject.DL;
using MidsProject.UI;
using MidsProject.BL;

namespace MidsProject
{
    class Program
    {
        static void Main(string[] args)
        {

            if (userdl.stu1.Count == 0)
            {
                userbl us = new userbl();
                us.setname("admin");
                us.setpassword("admin");
                userdl.adduserlist(us);
            }
            //Menus.loading();
            Console.Clear();
            string option;
            bool n = true;
            while (n)
            {
                option = menusui.mainpage();
                if (option == "2")
                {
                    userui.signup();
                }
                else if (option == "1")
                {
                    userui.signin();
                }
                else if (option == "3")
                {
                    //saveuserdata(stu1);
                    //savebooksdata(stu2);
                    //saveborrowdata(stu);
                    n = false;
                }
            }
            menusui.clear();


        }
    }
}
