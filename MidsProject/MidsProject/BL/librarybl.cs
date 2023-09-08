using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidsProject.DL;
using MidsProject.UI;

namespace MidsProject.BL
{
    class librarybl
    {
        private string borrow;
        private int date;
        private int month;
        private string borrowuser;
        private int currentdate = 0;
        private int fines = 0;
        public librarybl()
        {

        }
        public librarybl(string borrow,string borrowuser,int date,int month)
        {
            this.borrow = borrow;
            this.borrowuser = borrowuser;
            this.date = date;
            this.month = month;
        }
        public librarybl(int currentdate)
        {
            this.currentdate = currentdate;
        }
        public void setfine(int fine)
        {
            this.fines = fine;
        }
        public void setcurrentdate(int currentdate)
        {
            this.currentdate = currentdate;
        }
        public void setdate(int date)
        {
            this.date = date;
        }
        public void setmonth(int month)
        {
            this.month = month;
        }
        public void setborrow(string borrow)
        {
            this.borrow = borrow;
        }
        public void setborrowuser(string borrowuser)
        {
            this.borrowuser = borrowuser;
        }
        
        public int getfine()
        {
            return fines;
        }
        public int getcurrentdate()
        {
            return currentdate;
        }
        public int getdate()
        {
            return date;
        }
        public int getmonth()
        {
            return month;
        }
        public string getborrow()
        {
            return borrow;
        }
        public string getborrowuser()
        {
            return borrowuser;
        }

    }
}
