using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_WEB_APP
{

    static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool x = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    
    public class food
    {
        string name;
        int price;
        string code;
        public food(string name, int price, string code)
        {
            this.name = name;
            this.price = price;
            this.code = code;
        }
        public string getName()
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }
        public string getCode()
        {
            return code;
        }
    }

    public class drink
    {
        string name;
        int price;
        string code;
        public drink(string name, int price, string code)
        {
            this.name = name;
            this.price = price;
            this.code = code;
        }
        public string getName()
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }
        public string getCode()
        {
            return code;
        }
    }
    public class user
    {
        string name;
        string familyName;
        string phoneNumber;
        string address;
        string userName;
        string Email;
        string password;
        public user(string name, string familyName, string phoneNumber, string address, string userName, string Email, string password)
        {
            this.name = name;
            this.familyName = familyName;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.userName = userName;
            this.Email = Email;
            this.password = password;
        }
        public void changeInformation(string name, string familyName, string phoneNumber, string address, string userName, string Email,string password)
        {
            this.name = name;
            this.familyName = familyName;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.userName = userName;
            this.Email = Email;
            this.password = password;
        }
        public string getName()
        {
            return name;
        }
        public string getFamilyName()
        {
            return familyName;
        }
        public string getPhoneNumber()
        {
            return phoneNumber;
        }
        public string getAddress()
        {
            return address;
        }
        public string getUserName()
        {
            return userName;
        }
        public string getEmail()
        {
            return Email;
        }
        public string getPassword()
        {
            return password;
        }
    }

}
