using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Class
{
    class Program
    {
        static void Main(string[] args)
        {           
            //input();

            string firstName, lastName, address1, address2, city, state, country;
            DateTime birthday;
            int zipCode;

            Console.WriteLine("Enter student: First Name, Last Name, Birthdate, Address Line 1, Address Line 2, City, State/Province, Zip/Postal, Country");

            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            birthday = Convert.ToDateTime(Console.ReadLine());
            address1 = Console.ReadLine();
            address2 = Console.ReadLine();
            city = Console.ReadLine();
            state = Console.ReadLine();
            zipCode = Convert.ToInt32(Console.ReadLine());
            country = Console.ReadLine();

            Console.WriteLine("\nFirst Name: " + firstName + "\nLast Name: " + lastName + "\nBirthdate: " + birthday + "\nAddress Line 1: " + address1 + "\nAddress Line 2: " + address2 + "\nCity: " + city + "\nState/Province: " + state + "\nZip/Postal: " + zipCode + "\nCountry " + country);
            Console.Read();
        }
        //static void input()
        //{
           
        //}
        //static void Main(string[] args)
        //{
        //    string line = "OXOXOXOX";
        //    for (int i = 1; i <= 8; i++ )
        //    {
        //        if (line == "XOXOXOXO")
        //        {
        //            line = "OXOXOXOX";
        //        }
        //        else
        //        {
        //            line = "XOXOXOXO";
        //        }
        //        Console.WriteLine(line);
        //    }
        //    Console.Read();
        //}
    }
}
