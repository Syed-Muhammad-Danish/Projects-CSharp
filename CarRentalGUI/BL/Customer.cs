using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalGUI.BL
{
    public class Customer
    {
        protected string name;
        protected string idCard;
      //  protected string phone;
        protected string address;

        public Customer(string name)
        {
            this.name = name;
        }

        public Customer(string name,string idCard,string address)
        {
            this.name = name;
            this.idCard = idCard;
            this.address = address;
           // this.phone = phone;
        }
        public string Name { get => name; set => name = value; }
        public string IdCard { get => idCard; set => idCard = value; }
       
        public string Address { get => this.address; set => this.address = value; }
    }
}
