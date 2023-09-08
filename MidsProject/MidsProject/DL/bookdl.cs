using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidsProject.BL;
using MidsProject.UI;

namespace MidsProject.DL
{
    class bookdl
    {
        public static List<bookbl> stu2 = new List<bookbl>();
        public static void addbooklist(bookbl s)
        {
            stu2.Add(s);
        }
        public static void Printbooklist()
        {

            for (int i = 0; i < stu2.Count; i++)
            {
                booksui.printbookList(stu2[i]);
            }
        }

        public static bool Booklist()
        {
            if (stu2.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool checkremovebook()
        {
            if (stu2.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckRemovebook(string rmbknm, string rmauthor)
        {
            for (int i = 0; i < stu2.Count; i++)
            {
                if (rmbknm == stu2[i].getbooks() && rmauthor == stu2[i].getauthor())
                {
                    stu2.RemoveAt(i);
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }
        public static bool Printsearch(string seebknm)
        {
            for (int i = 0; i < stu2.Count; i++)
            {
                if (seebknm == stu2[i].getbooks())
                {
                    booksui.Printbook(stu2[i]);
                    return true;
                }

            }
            return false;
        }
        public static bool Printauthsearch(string seeauth)
        {
            for (int i = 0; i < stu2.Count; i++)
            {
                if (seeauth == stu2[i].getauthor())
                {
                    booksui.Printauth(stu2[i]);
                    return true;

                }
            }
            return false;
        }
    }

}
