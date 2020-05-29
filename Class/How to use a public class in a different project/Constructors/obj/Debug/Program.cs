using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persons = new Person { Fname = "Ela"};
            Console.WriteLine(persons.Fname);
        }
    }
}
