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
    public interface IBooking
    {
        double endBooking(double price);
    }
}
