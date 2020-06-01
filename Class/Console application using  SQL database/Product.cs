using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tablo'nun class karsiligi
namespace AdoNetDemo
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int StockAmount { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
