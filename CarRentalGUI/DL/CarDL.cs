using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalGUI.BL;
using System.IO;

namespace CarRentalGUI.DL
{
    public class CarDL
    {
        private static List<Car> cars = new List<Car>();

        public static List<Car> Cars { get => cars; set => cars = value; } // lambda operator getter setter

        public static Car fetchUnBook(string type)
        {
            foreach(var fetchCar in cars)
            {
                if (type == fetchCar.Type && fetchCar.isBooked == false)
                    return fetchCar;
            }
            return null;
        }
        public static void writeCarinFile() // write operation in file
        {
            string path = "dataCars.txt";
            StreamWriter file = new StreamWriter(path);
            foreach(Car writeCars in cars)
            {
                file.WriteLine(writeCars.LicensePlate+","+writeCars.EngineNo + "," +
                               writeCars.ChassisNo + "," +writeCars.KmsReading + "," +writeCars.Type+","+writeCars.Maint.OilChange);
                file.Flush();
            }
            file.Close();
        }
        public static void readCarFromFile() // Read Operation in file
        {
            string path = "dataCars.txt";
            StreamReader file = new StreamReader(path);
            if(File.Exists(path))
            {
                string item = "";
                while((item = file.ReadLine()) != null)
                {
                    string[] record = item.Split(',');
                    string licensePlate = record[0];
                    string engineNo = record[1];
                    string chassisNo = record[2];
                    double kmsReading = Convert.ToDouble(record[3]);
                    string type = record[4];
                    double maintReading = Convert.ToDouble(record[5]);
                    Car c = new Car(licensePlate,engineNo,chassisNo,kmsReading,type,maintReading);
                    if(!isCarAlreadyExist(c))
                    addCar(c);
                }
                file.Close();
            }
        }
        public static void addCar(Car c)
        {
            cars.Add(c);
        }
        public static void clearList()
        {
            cars.Clear();
        }
        public static bool isCarAlreadyExist(Car c)
        {
            foreach(Car car in cars)
            {
                if(c.LicensePlate == car.LicensePlate)
                {
                    return true;
                }
            }
            return false;
        }
        public static void deleteCar(Car deleted)
        {
            cars.Remove(deleted);
        }
        public static Car getAcar(string licensePlate)
        {
            foreach(Car c in cars)
            {
                if(licensePlate == c.LicensePlate)
                {
                    return c;
                }
            }
            return null;
        }
        public static void updateCar(Car prev,Car updated)
        {
            int count = 0;
            foreach(var selectCar in cars)
            {
                if(prev.LicensePlate == selectCar.LicensePlate)
                {
                    cars.Remove(prev);
                    cars.Insert(count, updated);
                    break;
                }
                count++;
            }
        }
    }
}
