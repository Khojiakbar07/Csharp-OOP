using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Student[] s = new Student[5];// Array of objects.
            s[0] = new Student( "Sherlock Holmes",  "B-221 Street", 48, "sherlocked@gmail.com");
            s[1] = new Student( "Will Smitt", "New York City", 50, "willsmitt@gmail.us");
            s[2] = new Student( "Jason Statham", "Washington", 55 , "jasonstatham@icloud.us");
            s[3] = new Student( "Michael Jakcson", "Brooklyn", 52, "michaelj@icloud.com");
            s[4] = new Student( "Tom Holland", "Queens",  26, "tomhollandd@gmail.com");
            s[5] = new Student( "Ryan Ryolds", "New York", 33, "ryanryolds@gmail.us");
            Console.ReadLine();*/

            Console.Write("Enter your Name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your Address: ");
            string address = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your Age: ");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter your Email: ");
            string Email = Convert.ToString(Console.ReadLine());

            Student student = new Student(name, address,age, Email);
            Console.WriteLine(student);

            Console.ReadLine();

        }
    }
}
          
