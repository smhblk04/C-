using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_injection
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.logger = new DatabaseLogger();
            //customerManager.Add();

            CustomerManager customerManager = new CustomerManager(new DatabaseLogger());
            customerManager.Add();
        }
    }

    //interface ILogger{void Log(); }
    //class DatabaseLogger : ILogger { public void Log() { Console.WriteLine("Added to Database."); } }
    //class FileLogger : ILogger { public void Log() { Console.WriteLine("Added to File."); } }
    //class CustomerManager
    //{
    //    public ILogger logger { get; set; }
    //    public void Add()
    //    {
    //        logger.Log();
    //        Console.WriteLine("Customer Added.");
    //    }
    //}

    interface ILogger { void Log(); }
    class DatabaseLogger : ILogger { public void Log() { Console.WriteLine("Added to Database."); } }
    class FileLogger : ILogger { public void Log() { Console.WriteLine("Added to File."); } }
    class CustomerManager
    {
        private ILogger _logger;
        public CustomerManager(ILogger logger) { _logger = logger; }//Constructor injection
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Customer Added.");
        }
    }
}
