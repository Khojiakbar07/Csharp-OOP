using OOP;
using System;
using System.Collections;
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
           // List<string> arraylist = new List<string>();
            ArrayList arraylist = new ArrayList();
            Student[] s = new Student[5];
            Student student1 = new Student( "Sherlock Holmes",  "B-221 Street", 48, "sherlocked@gmail.com");
            Student student2 = new Student("Will Smitt", "New York City", 50, "willsmitt@gmail.us");
            Student student3 = new Student("Jason Statham", "Washington", 55, "jasonstatham@icloud.us");
            Student student4 = new Student("Michael Jakcson", "Brooklyn", 52, "michaelj@icloud.com");
            Student student5 = new Student("Tom Holland", "Queens", 26, "tomhollandd@gmail.com");
            Student student6 = new Student("Ryan Ryolds", "New York", 33, "ryanryolds@gmail.us");
            arraylist.Add(student1);
            arraylist.Add(student2);
            arraylist.Add(student3);
            arraylist.Add(student4);
            arraylist.Add(student5);
            arraylist.Add(student6);
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter your Name: ");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Enter your Address: ");
                string address = Convert.ToString(Console.ReadLine());
                Console.Write("Enter your Age: ");
                int age = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter your Email: ");
                string Email = Convert.ToString(Console.ReadLine());

            }
            Console.WriteLine(arraylist.ToString());
            Console.ReadLine();
            Console.WriteLine("Please enter an address: ");
            String anyAddress = Convert.ToString(Console.ReadLine());
            //address
            for (int i = 0; i < s.Length; i++) {
               if (s[i].GetAddress().equals(anyAddress));
                    Console.WriteLine(s[i]);
                }
            //---------
            for (int i=0; i<s.Length; i++)
            {
                if (arraylist.getEmail().contains("gmail.com"))
                    Console.WriteLine(arraylist);
            }
        }
    }
}


        
