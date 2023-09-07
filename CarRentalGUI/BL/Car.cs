using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalGUI.BL
{
    public class Car
    {
        private string licensePlate;
        private string engineNo;
        private string chassisNo;
        private double kmsReading;
        private Maintenance maint;
        private string type;
        public bool isBooked;
        public Car()
        { }

        public Car(string licensePlate, string engineNo, string chassisNo, double kmsReading,string type,double maintReading)
        {
            this.licensePlate = licensePlate;
            this.engineNo = engineNo;
            this.chassisNo = chassisNo;
            this.kmsReading = kmsReading;
            this.maint = new Maintenance(maintReading);
            this.type = type;
            isBooked = false;
        }

        public string LicensePlate { get => licensePlate; set => licensePlate = value; }
        public string EngineNo { get => engineNo; set => engineNo = value; }
        public string ChassisNo { get => chassisNo; set => chassisNo = value; }
        public double KmsReading { get => kmsReading; set => kmsReading = value; }
       
        public string Type { get => type; set => type = value; }
        public Maintenance Maint { get => maint; set => maint = value; }

        public virtual string busB()
        {
            return null;
        }
    }
}
