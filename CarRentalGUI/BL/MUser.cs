using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalGUI.BL
{
    public class MUser
    {
        public MUser(string username)
        {
            this.username = username;
        }
        public MUser(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public MUser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public MUser()
        {
            username = "";
            password = "";
            role = "";
        }
        private string username;
        private string password;
        private string role;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public bool isAdmin()
        {
            if (role == "ADMIN")
                return true;
            return false;
        }
        public bool isCustomer()
        {
            if (role == "CUSTOMER")
                return true;
            return false;
        }
    }
}
