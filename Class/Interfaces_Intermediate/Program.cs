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
            //Musteri Oracle tabanli ise;
            //ICustomerDal customer = new OracleCustomerDal();
            //customer.Add();
            //customer.Delete();

            //Musteri Sql tabanli ise;
            //ICustomerDal customer2 = new SqlServerCustomerDal();
            //customer2.Add();
            //customer2.Update();

            //More convenient to use:(Gecisi kolaylastirmak icin veya uygulamanin bagimliliklarini azaltmak icin)
            //CustomerManager customer3 = new CustomerManager();
            //customer3.Add(new OracleCustomerDal());
            //customer3.Add(new SqlServerCustomerDal());

            //How to add multiple customers to each databases?
            ICustomerDal[] customerdals = new ICustomerDal[2]
            {
                new OracleCustomerDal(), new SqlServerCustomerDal()
            };

            foreach (var customerDal in customerdals)
            {
                customerDal.Add();
            }

            //or

            ICustomerDal customer = new OracleCustomerDal();
            customer.Add();

            customer = new SqlServerCustomerDal();
            customer.Add();

            //Sonuc olarak: ustteki kullanim, sayi daha fazla olursa kullanmasi daha kolay olur
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
