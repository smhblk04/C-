using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try { Find(); }
            catch(RecordNotFoundException exception) { Console.WriteLine(exception.Message); }

            Console.WriteLine("");
            Console.WriteLine("Exception handling with action delegation:");

            HandleException(() => { Find(); }); //HandleException'a parametresiz method veya kod blogu gonderecegim demek.

            Console.ReadLine();
        }
        private static void HandleException(Action action)//Action: gonderdigin method'u simgeler, parametre almaz, ve void'tir
        {
            try { action.Invoke(); }//Gonderilen method'u calistiriyor, invoke() sayesinde
            catch (Exception exception) { Console.WriteLine(exception.Message); }
        }

        private static void Find()
        {
            List<string> student = new List<string> { "James", "Jeffrey", "Bean" };
            if (!student.Contains("Ahmet"))
                throw new RecordNotFoundException("Record not found.");
            else
                Console.WriteLine("Record found.");
        }
    }
}
