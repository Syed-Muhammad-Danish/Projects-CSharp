using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidsProject.DL;
using MidsProject.UI;

namespace MidsProject.BL
{
    class bookbl
    {
        private string books;
        private string author;
        private string publishdate;
        private string choice;
        public bookbl()
        {

        }
        public bookbl(string books,string author)
        {
            this.books =books;
            this.author =author;
        }
        public bookbl(string books,string author,string publishdate)
        {
            this.books =books;
            this.author =author;
            this.publishdate =publishdate;
        }
        public bookbl(string books,string author,string publishdate,string choice)
        {
            this.books =books;
            this.author =author;
            this.publishdate =publishdate;
            this.choice = choice;
        }
        public void setbooks(string books)
        {
            this.books = books;
        }
        public void setchoice(string choice)
        {
            this.choice = choice;
        }
        public void setauthor(string author)
        {
            this.author = author;
        }
        public void setpublishdate(string publishdate)
        {
            this.publishdate=publishdate;
        }
        public string getbooks()
        {
            return books;
        }
        public string getauthor()
        {
            return author;
        }
        public string getpublishdate()
        {
            return publishdate;
        }
        public string getchoice()
        {
            return choice;
        }
    }
}
