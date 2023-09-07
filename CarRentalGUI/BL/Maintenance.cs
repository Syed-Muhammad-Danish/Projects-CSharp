using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalGUI.BL
{
    public class Maintenance
    {
        private double oilChange;
        private string comments;
        public Maintenance()
        {
            oilChange = 3000;
            comments = "fine";
        }
        public Maintenance(double value)
        {
            oilChange = value;
            comments = "fine";
        }
        public Maintenance(double oilChange,string comments)
        {
            this.oilChange = oilChange;
            this.comments = comments;
        }
        public double OilChange { get => oilChange; set => oilChange = value; }
        public string Comments { get => comments; set => comments = value; }
    }
}
