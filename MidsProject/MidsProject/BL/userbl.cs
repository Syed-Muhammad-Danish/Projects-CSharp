using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidsProject.DL;
using MidsProject.UI;

namespace MidsProject.BL
{
    class userbl
    {
        private string name = "";
        private string password = "";
        private int currentindex;
        public userbl()
        {

        }
        public void setindex(int x)
        {
            this.currentindex = x;
        }
        public int getindex()
        {
            return  currentindex;
        }
        public userbl(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public userbl(string password)
        {
            this.password = password;
        }
        public string getname()
        {
            return name;
        }
        public string getpasswor()
        {
            return password;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public void setpassword(string name)
        {
            this.password = name;
        }
    }
}
