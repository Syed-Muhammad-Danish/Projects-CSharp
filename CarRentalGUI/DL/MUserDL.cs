using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CarRentalGUI.BL;

namespace CarRentalGUI.DL
{
    public class MUserDL
    {
        private static List<MUser> user = new List<MUser>();
       
        public static List<MUser> User { get => user; }    //read only attribute
       

        public static MUser getReference(string name, string pass)
        {
            foreach (var i in User)
            {
                if (name == i.Username && pass == i.Password)
                {
                    return i;
                }
            }
            return null;
        }
      
        public static void addintoList(MUser m)
        {
            User.Add(m);
        }
        public static void writeInFile()
        {
            string path = "dataUser.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (MUser i in user)
            {
                file.WriteLine(i.Username + "," + i.Password + "," + i.Role);
                file.Flush();
            }
            file.Close();

        }
        public static void LoadFromFile()
        {

            string path = "dataUser.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string item = "";
                while ((item = file.ReadLine()) != null)
                {
                    string[] record = item.Split(',');
                    string usernameA = record[0];
                    string passwordA = record[1];
                    string role = record[2];
                    MUser obj = new MUser(usernameA, passwordA, role);
                    User.Add(obj);
                }
                file.Close();
            }
        }
    }
}
