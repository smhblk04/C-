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
            //Multiple implementations:

            IWorker[] workers = new IWorker[3]
                { new Manager(), new Worker(), new Robot()};
            foreach (var worker in workers)
            { worker.work(); }

            IEat[] eats = new IEat[2]
                { new Manager(), new Worker()};
            foreach (var eat in eats)
            { eat.eat(); }

            ISalary[] salaries = new ISalary[2]
                { new Manager(), new Worker()};
            foreach (var salary in salaries)
            { salary.GetSalary(); }
        }
    }

    interface IWorker
    {
        void work();
    }

    interface IEat
    {
        void eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void work()
        {
            throw new NotImplementedException();
        }
    }
   
}
