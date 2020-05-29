using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ilk durum:
            //CustomerManager manager = new CustomerManager();
            //manager.Logger = new DatabaseLogger();
            //manager.Add();

            //Console.ReadLine();

            //ikinci durum
            CstmrManager manager = new CstmrManager();
            manager.Add(2);

            Console.ReadLine();
        }
    }

    //ikinci durum: kendi buldugum cozum
    class CstmrManager
    {
        public void Add(int i)
        {
            if (i == 1){ DtbsLogger logger = new DtbsLogger(); logger.Log(); }
            else if (i == 2) { FlLogger logger = new FlLogger(); logger.Log(); }

            Console.WriteLine("Customer Added.");
        }
    }

    class DtbsLogger
    {
        public void Log()
        {
            Console.WriteLine("Added to Database.");
        }
    }

    class FlLogger
    {
        public void Log()
        {
            Console.WriteLine("Added to File.");
        }
    }

    //ilk durum
    class CustomerManager
    {
        public ILogger Logger { get; set; }//Burasi kritik nokta
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added.");
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Added to Database.");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Added to File.");
        }
    }


}
