using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Arraylist, List, Dictionary

//Referans tipler
//-class, array, interface, abstract class, string

//ArrayList syntax:
//ArrayList cities = new ArrayList();
//cities.Add();

//-type-safe: girilen veri tipi fark etmez, int, string, char vs.

//List kullanimi veya syntax'i:
//List<string> cities = new List<string>(); //sadece string ile calisilabilir

//Class Customer
//{
//public int Id { get; set; }
//public string Fname { get; set; }
//}

//List<Customer> customers = new List<Customer>;
//Customers.Add(new Customer(Id= 1, Fname=“Mehmet”));

//-elemanlari silmek icin clear()
//-Contains() : checks whether that the element is in the list or not
//-IndexOf() : aradigimiz elemanın listedeki yeri
//-Insert() : element nereye eklemek istediğin yeri belirtiyorsun
//-Remove() : silmek istediğin elemanı belirterek silebiliyorsun ve bulduğu ilk degeri siliyor
//RemoveAll(): Remove()'dan tek farki belirtilen elemani, liste'deki her yerden siliyor


//Dictionary
//-Anahtar ile deger’e ulaşmak istediğimiz zaman kullanıyoruz
//Dictionary<key, value>
//Dictionary<string, string> dictionary = new Dictionary<string, string>();
//Dictionary.Add(“computer”, “bilgisayar”);

//console.writeline(dictionary[“computer”]) -> prints: bilgisayar

//foreach(var item in dictionary)
//	console.writeline(item) -> prints: [computer, bilgisayar]
//console.writeline(item.key) -> prints computer

//    console.writeline(item.value) -> prints: bilgisayar

//Dictionary.containskey(): key var mi yok mu, boolean
//Dictionary.containsvalue(): value var mi yok mu, boolean

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer{ Fname="Mahmut", Id=1}, new Customer{ Fname="Yesim", Id=2}
            };
            var count = customers.Count;
            Console.WriteLine("Number of elements currently: {0}", count);
            var customer2 = new Customer { Id=3, Fname="Kamil"};
            customers.Add(customer2);
            customers.AddRange(new Customer[2] { new Customer { Id = 4, Fname = "Efe" }, new Customer { Id = 5, Fname = "Mustafa" } });
            Console.WriteLine("");
            Console.WriteLine("Elements are: ");
            foreach (var customer in customers)
                Console.WriteLine(customer.Fname);

            Console.WriteLine("");
            Console.WriteLine("New elements are:");
            var customer3 = new Customer { Id=9, Fname="Michael"};
            customers.Insert(3, customer3);
            customers.Insert(0, customer3);
            customers.Insert(6, customer3);
            foreach (var customer in customers)
                Console.WriteLine(customer.Fname);

            Console.WriteLine("");
            Console.WriteLine("Remove Michael from list: ");
            customers.RemoveAll(c=>c.Fname=="Michael");

            Console.WriteLine("");
            Console.WriteLine("New newww elements are:");
            foreach (var customer in customers)
                Console.WriteLine(customer.Fname);

            Console.WriteLine("");
            Console.WriteLine("Dictionaries: ");
            Dictionary<string, string> dictionaries = new Dictionary<string, string>();
            dictionaries.Add("Glass", "Bardak");
            dictionaries.Add("Computer", "Bilgisayar");
            dictionaries.Add("Green", "Yesil");
            dictionaries.Add("Table", "Masa");

            foreach(var dictionary in dictionaries)
            {
                Console.WriteLine(dictionary);
            }

            Console.WriteLine("");
            Console.WriteLine("Dictionary keys: ");
            foreach (var dictionary in dictionaries)
            {
                Console.WriteLine(dictionary.Key);
            }

            Console.WriteLine("");
            Console.WriteLine("Dictionary values: ");
            foreach (var dictionary in dictionaries)
            {
                Console.WriteLine(dictionary.Value);
            }

            Console.WriteLine("");
            Console.WriteLine("Check some values: ");
            if (dictionaries.ContainsKey("Green") == true)
                Console.WriteLine("Green as a key is in the dictionary");
            else
                Console.WriteLine("Green as a key is not in the dictionary");
        }
    }

    class Customer
    {
        public string Fname { get; set; }
        public int Id { get; set; }
    }
    class SingleObject
    {
        static SingleObject _singleObject;//getInstance() fonksiyonu static oldugu icin _singleObject de static olmasi gerekiyor.
        //Cunku static olarak tanimlanan bir scope'ta butun attribute ve fonksiyonlar static olmali
        private SingleObject() {} //In order to make the class cannot be instantiated, constructor is setted to be private
        public static SingleObject getInstance() { return _singleObject; }//Butun objelerin ayni olmasini saglayan yer burasi.
    }
}