using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.City = "Elazig";
            customer.Id = 1;
            customer.Fname = "Mahmut";
            customer.Lname = "Yildirim";

            Customer customer2 = new Customer { Id=2, City="Antep", Fname="Mustafa", Lname="Gunal"};
            Console.WriteLine(customer2.Fname);
            Console.ReadLine();
        }
    }
}
