using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(23);
            customerManager.List();

            Console.WriteLine("");
            Console.WriteLine("Default constructor");
            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.List();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager(int count) { _count = count; }
        public CustomerManager() { }//Default constructor, obje construct edildigi zaman herhangi bir deger verilmezse, count=15 degerini default olarak aliyor
        public void List(){ Console.WriteLine("Listed {0} items.", _count); }

    }
}
