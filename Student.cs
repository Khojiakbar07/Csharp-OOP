using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Student
    {
        private string Name;
        private string Email;
        private string Address;
        private int Age;


        public Student(string aName, string aAddress, int aAge,string aEmail)
        {
            this.Name= aName;
            this.Address = aAddress;
            this.Age = aAge;
            this.Email = aEmail;
            
            
        }
        /*getter and setter*/
        public string name 
        {
            get { return name; }
            set {
                    Name = value;
                }

        }
        public string email
        {
            get { return email; }
            set
            {
                Email = value;
            }

        }
        public string address
        {
            get { return address; }
            set
            {
                Address = value;
            }

        }
        public int age
        {
            get { return age; }
            set
            {
                Age = value;
            }

        }
        /*getter and setter end*/
        public String toString()
        {
            return "Name: " + name + ", Address: " + address + ", Age: " + age + ", Email: " + email;
        }

        
    }

}


