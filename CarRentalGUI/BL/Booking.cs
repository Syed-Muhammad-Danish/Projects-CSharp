using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalGUI.Forms;
using CarRentalGUI.BL;
using CarRentalGUI.DL;

namespace CarRentalGUI.BL
{
    public class Booking: IBooking
    {
        private Car isCurrentlyBook;
        private Customer isBookCustomer;
        private string bookCode;
        private DateTime date;
       // private DateTime endDate;

        public Booking(Car isCurrentlyBook, Customer isBookCustomer,DateTime date)
        {
            this.isCurrentlyBook = isCurrentlyBook;
            this.isBookCustomer = isBookCustomer;
            BookCode = null;
            this.date = date;
        }
        public Car IsCurrentlyBook { get => isCurrentlyBook; set => isCurrentlyBook = value; }
        public string BookCode { get => bookCode; set => bookCode = value; }
        public Customer IsBookCustomer { get => isBookCustomer; set => isBookCustomer = value; }
        public DateTime Date { get => date; set => date = value; }

        public static string randomCodeGenerator()
        {
            Random random = new Random(); // generating a random string 
            StringBuilder str = new StringBuilder();
            char ch ;
            
            for(int i = 0; i < 7;i++)
            {
                double number = random.NextDouble();
                int check = Convert.ToInt32(Math.Floor(25 * number)); // getting a random string bw 0 and 25
                ch = Convert.ToChar(check + 65); // converting floor int value to character for appending in string
                                                 // builder
                str.Append(ch);
            }
            return Convert.ToString(str);
        }
        public double endBooking(double price)
        {
            DateTime end = DateTime.Today;
            double rentalP = 0.0d;
            TimeSpan  t= end.Subtract(this.date);
            string diff = t.ToString();
          
            diff = (end - this.date).TotalDays.ToString();
            rentalP = price * (Convert.ToDouble(diff) + 1.0);
            return rentalP;
        }
    }
}
