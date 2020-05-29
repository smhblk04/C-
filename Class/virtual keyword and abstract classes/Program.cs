using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Database[] databases = new Database[3] { new Database(), new SqlServer(), new OracleServer() };
            foreach (var database in databases)
            { database.Add(); Console.WriteLine(""); }

            Console.WriteLine("");
            Console.WriteLine("Using abstract class:");
            Dtbs[] databases2 = new Dtbs[2] { new SqlSrvr(), new OrclSrvr() };
            foreach(var database in databases2) { database.Add(); database.Delete(); }

            Console.ReadLine();
        }
    }

    //Virtual'u kullanmamizin sebebi: sub class'larda ayni fonksiyona farkli ozellik kazatabilmek icin
    class Database
    {
        public virtual void Add() { Console.WriteLine("Added by default"); }
        public virtual void Delete() { Console.WriteLine("Deleted by default"); }
    }

    class SqlServer : Database
    {
        //base.Add() ile inherit edilen yani base class'in Add() fonksiyonunu cagiriyorsun
        public override void Add() { Console.WriteLine("Added by Sql"); base.Add(); }
        public override void Delete() { Console.WriteLine("Deleted by Sql"); }
    }

    class OracleServer : Database
    {
        public override void Add() { Console.WriteLine("Added by Oracle"); base.Add(); }
        public override void Delete() { Console.WriteLine("Deleted by Oracle"); }
    }

    //Abstract class
    //Abstract class'in kendi instance'i olmaz, interface gibi
    abstract class Dtbs
    {
        public void Add() { Console.WriteLine("Added by Default"); }

        public abstract void Delete();//fonksiyon'a abstract koymamizin sebebi, bu fonksiyon'u sub class'larda override edecegiz
    }

    class SqlSrvr : Dtbs
    {
        public override void Delete()
        {
            Console.WriteLine("Added by Sql.");
        }
    }

    class OrclSrvr : Dtbs
    {
        public override void Delete()
        {
            Console.WriteLine("Added by Oracle.");
        }
    }
}
