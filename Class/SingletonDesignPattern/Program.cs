using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleObject single = SingleObject.getInstance();
            SingleObject single1 = SingleObject.getInstance();

            if (single == single1)
                Console.WriteLine("Same");
            else
                Console.WriteLine("Not Same.");
        }
    }
    class SingleObject
    {
        static SingleObject _singleObject;//getInstance() fonksiyonu static oldugu icin _singleObject de static olmasi gerekiyor.
        //Cunku static olarak tanimlanan bir scope'ta butun attribute ve fonksiyonlar static olmali
        private SingleObject() {} //In order to make the class cannot be instantiated, constructor is setted to be private
        public static SingleObject getInstance() { return _singleObject; }//Butun objelerin ayni olmasini saglayan yer burasi.
    }
}