using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalGUI.BL;
using System.IO;

namespace CarRentalGUI.DL
{
    public class CustomerDL
    {
        private static List<Customer> customers = new List<Customer>();
        public static List<Customer> Customers { get => customers; }
        public static void addCust(Customer c)
        {
            customers.Add(c);
        }
        public static void writeCustomerFromFile()
        {
            string path = "dataCustomer.txt";
            StreamWriter file = new StreamWriter(path);
            foreach(var c in customers)
            {
                file.WriteLine(c.Name+","+c.IdCard + "," +c.Address);
                file.Flush();
            }
            file.Close();
        }
        public static void readCustomerfromFile()
        {
            string path = "dataCustomer.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string item = "";
                while((item = file.ReadLine()) != null)
                {
                    string[] record = item.Split(',');
                    string name = record[0];
                    string idCard = record[1];
                    string address = record[2];
                    Customer cust = new Customer(name, idCard, address);
                    if(!isCustomerAlreadyExist(cust))
                    {
                        addCust(cust);
                    }
                }
                file.Close();
            }
        }
        public static void editCust(Customer prev, Customer updated)
        {
            int count = 0;
            foreach (Customer c in customers)
            {
                if (prev.Name == c.Name)
                {
                    customers.Remove(prev);
                    break;
                }
                count++;
            }
            customers.Insert(count, updated);
        }
        public static bool isCustomerHaveDetails(Customer c)
        {
            if (c.Address == null || c.IdCard == null)
            {
                return false;
            }
            return true;
        }
        public static bool isCustomerAlreadyExist(Customer c)
        {
            foreach (var f in customers)
            {
                if (c.Name == f.Name && c.Address == f.Address && c.IdCard == f.IdCard)
                {
                    return true;
                }
            }
            return false;
        }
        public static Customer fetchCustomer(Customer c)
        {
            foreach (var fetchCust in customers)
            {
                if (fetchCust.Name == c.Name)
                {
                    return fetchCust;
                }
            }
            return null;
        }
        public static Customer getCustomerByName(string name)
        {
            foreach(var fetchCust in customers)
            {
                if (fetchCust.Name == name)
                    return fetchCust;
            }
            return null;
        }
    }
}
