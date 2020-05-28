using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.Id = 10;
            //customer.Fname = "Mahmut";
            //customer.Lname = "Yildirim";
            //customer.Address = "Esentepe";

            Customer customer = new Customer
            { Id = 10, Fname = "Mahmut", Lname = "Yildirim", Address = "Esentepe", };

            Console.WriteLine(customer.Fname);

            Student student = new Student { Id = 5, Fname = "Omer", Lname = "Seven", Department = "Management" };
            Console.WriteLine(student.Lname);
            Console.ReadLine();
        }
    }

    interface Iperson{ 
        int Id { get; set; }
        string Fname { get; set; }
        string Lname { get; set; }
    }

    class Customer : Iperson
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        //Functions can be defined as below;
        //public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string Fname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string Lname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //However, this implementation seems ugly
    }

    class Student : Iperson {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Department { get; set; }
    }
}
