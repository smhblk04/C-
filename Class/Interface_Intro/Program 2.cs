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

            //Customer customer = new Customer
            //{ Id = 10, Fname = "Mahmut", Lname = "Yildirim", Address = "Esentepe", };

            //Console.WriteLine(customer.Fname);

            //Student student = new Student { Id = 5, Fname = "Omer", Lname = "Seven", Department = "Management" };
            //Console.WriteLine(student.Lname);
            //Console.ReadLine();

            PersonManager personmanager = new PersonManager();//PersonManager instance'i olusturuldu
            personmanager.Add(new Customer { Id = 0, Fname = "Omer", Lname = "Seven" }) ;//PersonManager class'i dahilinde olusturulan class'in icerisinde Customer class'ina ait instance olusturuldu.

            Student student = new Student { Id=10, Fname = "Fatih", Lname = "Talay", Department="Management"};
            //personmanager.Add(student);//Personmanager class'i parametre olarak customer istiyor
            //Bunu cozebilmek icin; Personmanager class'inin parametresini Iperson interface'i yaparsan, farkli class'lar kullanabilirsin

            personmanager.Add(student);
            Console.ReadLine();

            //Iperson person = new Iperson();//Interface'in instance'i olmaz
            //Interface'in dahilinde olan bir class'in instance'i olabilir; Iperson person = new Customer(); veya Iperson person = new Student();

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

    //class PersonManager//Bu class'in ozelligi: Add fonksiyonunda Customer class'ina ait bir parametre gerektirmek
    //{
    //    public void Add(Customer customer)
    //    {
    //        Console.WriteLine(customer.Fname);
    //    }
    //}

    class PersonManager {
        public void Add(Iperson person)
        {
            Console.WriteLine(person.Fname);
        }
    }
}
