using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalGUI.BL;
using System.IO;

namespace CarRentalGUI.DL
{
    public class BookingDL
    {
        private static List<Booking> books = new List<Booking>();

        public static List<Booking> Books { get => books; set => books = value; }

        public static void addIntoList(Booking b)
        {
            books.Add(b);
        }
        public static void removeBooking(Booking b)
        {
            books.Remove(b);
        }
        public static Booking getDetails(string bookCode)
        {
            foreach (Booking b in books)
            {
                if(bookCode == b.BookCode)
                {
                    return b;
                }
            }
            return null;
        }
        public static void writeBookinginFile()
        {
            string path = "dataBookings.txt";
            StreamWriter file = new StreamWriter(path);
            foreach(var b in books)
            {
                file.WriteLine(b.IsCurrentlyBook.LicensePlate + "," +b.BookCode + "," +b.IsBookCustomer.Name + "," +b.Date.Day + ";" +b.Date.Month + ";" +b.Date.Year);
                file.Flush();
            }
            file.Close();
        }
        public static bool isBookingAlreadyExist(string bookCode)
        {
            foreach(Booking b in books)
            {
                if (b.BookCode == bookCode)
                    return true;
            }
            return false;
        }
        public static void readBookingFromFile()
        {
            string path = "dataBookings.txt";
            StreamReader file = new StreamReader(path);
            if(File.Exists(path))
            {
                CarDL.readCarFromFile();
                CustomerDL.readCustomerfromFile();
                string item = "";
                while((item = file.ReadLine()) != null)
                {
                    string[] record = item.Split(',');
                    Car isBookCar = CarDL.getAcar(record[0]);
                    isBookCar.isBooked = true;
                    Customer isBookCustomer = CustomerDL.getCustomerByName(record[2]);
                    string [] recordOfDate = record[3].Split(';');
                    DateTime date = new DateTime(int.Parse(recordOfDate[2]), int.Parse(recordOfDate[1]), int.Parse(recordOfDate[0]));
                    Booking b = new Booking(isBookCar, isBookCustomer, date);
                    b.BookCode = record[1];
                    if (!isBookingAlreadyExist(b.BookCode))
                    {
                        books.Add(b);
                    }
                }
            }
            file.Close();
        }
    }
}
