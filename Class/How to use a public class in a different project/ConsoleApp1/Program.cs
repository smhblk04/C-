using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Inheritance ile interface arasindaki fark;
//Herhangi bir class 1'den fazla yerden class'dan inherit edilemez, ama ayni sey interface icin gecerli degil.
//Asagidaki senaryo inheritance icin gecerli;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
                {
                    new Person{ Fname = "Mahmut"}, new Customer { Fname = "Baki"}, new Student { Fname = "Omer"}
                };
            Console.WriteLine("Implementation with inheritance: ");
            foreach (var person in persons) { Console.WriteLine(person.Fname); }

            IPerson[] ipersons = new IPerson[2] { new Cstmr { Fname = "Baki" }, new Stdnt { Fname = "Omer" } //,  new IPerson { Fname = "Fati"} ---> interface'in instance'i olmaz 
            };

            Console.WriteLine("");
            Console.WriteLine("Implementation with interface: ");
            foreach (var person in ipersons) { Console.WriteLine(person.Fname); }
            Console.ReadLine();
        }
    }

    //Suppose that Person2 is also a base class that you would like to use as an inherited class in Person and Student
    //class Person2 
    //{

    //}


    public class Person//Base class
    {
        //Following three functions are not needed to implement in the inherited classes, since they inherit from base class
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }

    //Other than the functions that are implemented at base class, the unique functions may be implemented at inherited classes
    class Customer : Person //, Person2 you cannot inherit from two base class, however, you could use a base class and one or more interfaces
    {
        public string City { get; set; }
    }

    class Student : Person 
    {
        public string Department { get; set; }
    }

    //Yukaridaki senaryo'nun interface olarak implement edilmis hali;

    interface IPerson
    {
        int Id { get; set; }
        string Fname { get; set; }
        string Lname { get; set; }
    }

    class Cstmr : IPerson
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public string City { get; set; }
    }

    class Stdnt : IPerson
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public string Department { get; set; }
    }
}

